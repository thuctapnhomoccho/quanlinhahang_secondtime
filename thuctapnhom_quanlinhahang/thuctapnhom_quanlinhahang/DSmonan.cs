using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuctapnhom_quanlinhahang.Object;
namespace thuctapnhom_quanlinhahang
{
    public partial class DSmonan : Form
    {
        public DSmonan()
        {
            InitializeComponent();
        }

        private void DSmonan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlinhahangDataSet6.loai_mon_an' table. You can move, or remove it, as needed.
            this.loai_mon_anTableAdapter.Fill(this.quanlinhahangDataSet6.loai_mon_an);
            load_dsmonan(id_hoadon, sobanan, tenkhachhang);
            txt_id_hoadon_dsmonan.Text = id_hoadon.ToString();
            txt_khachhang_dsmonan.Text = tenkhachhang;
            txt_sobanan.Text = sobanan.ToString();
            tinhtien(id_hoadon);
            data_dsmonan.Columns[3].Visible = false;

        }
        int id_hoadon = 0; int sobanan = 0; string tenkhachhang = null; int giatien = 0;
        public void load_dsmonan(int id,int soban,string tenkh)
        {
            

            data_dsmonan.RowHeadersVisible = false;
            Dsmonans ds = new Dsmonans();
           
            txt_thanhtien.Text = giatien.ToString();
            data_dsmonan.DataSource = ds.show_dsmonan(id);
            id_hoadon = id;
            sobanan = soban; 
            tenkhachhang = tenkh;
            enable_control(false);
            null_data_control();
            tinhtien(id);

          
        }

        public void tinhtien(int id)
        {
            Dsmonans ds = new Dsmonans();
            giatien = 0;
            List<DataRow> list = ds.show_dsmonan(id_hoadon).AsEnumerable().ToList();
            foreach (var item in list)
            {
                giatien = giatien + int.Parse(item[1].ToString()) * int.Parse(item[2].ToString());
            }
            txt_thanhtien.Text = giatien.ToString()+" VNĐ " ;
        }

        private void btn_huy_dsmonan_Click(object sender, EventArgs e)
        {
            load_dsmonan(id_hoadon,sobanan,tenkhachhang);
          
        }


        public void enable_control(bool bl)
        {
            txt_sobanan.Enabled = false;
            txt_id_hoadon_dsmonan.Enabled = false;
            txt_khachhang_dsmonan.Enabled = false;
            cb_loaimonan.Enabled = bl;
            cb_monan.Enabled = bl;
            txt_soluong.Enabled=bl;
            btn_chucnang_dsmonan.Enabled = bl;
            btn_huy_dsmonan.Enabled = bl;
            txt_thanhtien.Enabled = false;
            btn_chucnang_dsmonan.Visible = btn_huy_dsmonan.Visible = bl;
        }

        private void tooltrp_reset_dsmonan_Click(object sender, EventArgs e)
        {
            load_dsmonan(id_hoadon, sobanan, tenkhachhang);
        }

        private void data_dsmonan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                txt_thanhtien.Text = giatien.ToString();
                cb_loaimonan.SelectedValue = data_dsmonan.Rows[e.RowIndex].Cells[3].Value.ToString();
                cb_monan.Text = data_dsmonan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_soluong.Text = data_dsmonan.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

             
            }
            
            
        }
        string chucnang = null;
        private void tooltrp_insert_dsmonan_Click(object sender, EventArgs e)
        {
            enable_control(true);
            chucnang = "them";
            btn_chucnang_dsmonan.Text = "Thêm món ăn ";
        }

        private void btn_chucnang_dsmonan_Click(object sender, EventArgs e)
        {
            switch (chucnang)
            {
                case "them":
                    {
                        Dsmonans ds = new Dsmonans();
                        ds.id_hoadon = int.Parse(txt_id_hoadon_dsmonan.Text);
                        ds.id_monan = int.Parse(cb_monan.SelectedValue.ToString());
                        ds.soluong = int.Parse(txt_soluong.Text);
                        if (ds.insert_monan(ds))
                        {
                            MessageBox.Show("Bạn vừa thêm thành công hóa món ăn  " + cb_monan.Text + " hoàn tất !");
                        }
                        else
                        {
                            MessageBox.Show("Thất bại ! Bạn chưa thể thêm thành công món ăn vào hệ thống ! ");
                        }
                
                        load_dsmonan(id_hoadon,sobanan,tenkhachhang);
                        

                        return;
                    }
                case "sua":
                    {
                        Dsmonans hd = new Dsmonans();
                        hd.id_hoadon = int.Parse(txt_id_hoadon_dsmonan.Text);
                        hd.id_monan = int.Parse(cb_monan.SelectedValue.ToString());
                        hd.soluong = int.Parse(txt_soluong.Text);
                        if (hd.update_dsmonan(hd))
                        {
                            MessageBox.Show("Bạn vừa sửa thành công hóa món ăn " + cb_monan.Text + " hoàn tất !");
                        }
                        else
                        {
                            MessageBox.Show("Thất bại ! Bạn chưa thể sửa thành công món ăn vào hệ thống ! ");
                        }
                        load_dsmonan(id_hoadon, sobanan, tenkhachhang);
                        return;
                    }
                case "xoa":
                    {
                        Dsmonans hd = new Dsmonans();
                        String text = "Bạn có muốn xóa món ăn " + cb_monan.Text + " không ? ";
                        string caption = " Xóa nhân viên ";
                        var resuit = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resuit == DialogResult.Yes)
                        {
                            if (hd.delete_monan(int.Parse(txt_id_hoadon_dsmonan.Text), int.Parse(cb_monan.SelectedValue.ToString())))
                            {
                                MessageBox.Show("Bạn vừa xóa thành công món ăn " + cb_monan.Text + " ra khỏi hệ thống ");

                            }
                            else
                            {
                                MessageBox.Show("Thất bại ! Bạn chưa thể xóa món ăn " + cb_monan.Text + " ra khỏi hệ thống", "Thất bại ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        load_dsmonan(id_hoadon,sobanan,tenkhachhang);
                           null_data_control();
                        return;

                    }
                default:
                    break;
            }
        }

        private void cb_loaimonan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(cb_loaimonan.SelectedValue.ToString());
                Dsmonans ds = new Dsmonans();
                cb_monan.DataSource = ds.search_monan_theo_idloaimonan(i);
                cb_monan.DisplayMember = "name_monan";
                cb_monan.ValueMember = "id_monan";

            }
            catch (Exception)
            {

              
            }
       
        }

        private void tooltrp_update_dsmonan_Click(object sender, EventArgs e)
        {
            enable_control(true);
            chucnang = "sua";
            btn_chucnang_dsmonan.Text = "Sửa món ăn ";
            cb_loaimonan.Enabled = cb_monan.Enabled =false;
        }
        public void null_data_control()
        {
          txt_soluong.Text= cb_monan.Text=  cb_loaimonan.Text = null;

        }

        private void DSmonan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();

            f1.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            btn_chucnang_dsmonan.Visible =btn_huy_dsmonan.Visible=btn_chucnang_dsmonan.Enabled=btn_huy_dsmonan.Enabled= true;

            chucnang = "xoa";
            btn_chucnang_dsmonan.Text = "Xóa món ăn ";
            cb_loaimonan.Enabled = cb_monan.Enabled = false;
        }
    }
}
