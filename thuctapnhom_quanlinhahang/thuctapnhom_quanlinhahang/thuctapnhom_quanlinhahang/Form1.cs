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
using System.Data.Sql;


namespace thuctapnhom_quanlinhahang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void enable_control(bool bl)
        {
            txt_hoten.Enabled = bl;
            rb_nam.Enabled = bl;
            rb_nu.Enabled = bl;
            txt_diachi.Enabled = bl;
            txt_chucvu.Enabled = bl;
            txt_luong.Enabled = bl;
            txt_tendangnhap.Enabled = bl;
            txt_matkhau.Enabled = bl;
            txt_sdt.Enabled = bl;
            datetm_ngaysinh_nhanvien.Enabled = bl;
            
            
        }
        public void load_data_nhanvien()
        {
            btn_chucnang_nhanvien.Visible = false;
            enable_control(false);
            nhanvien nv = new nhanvien();
            datagrip_nhanvien.DataSource = nv.show_nhanvien();
            datagrip_nhanvien.RowHeadersVisible = false;
            datagrip_nhanvien.Columns[8].Visible = false;
            txt_hoten.Text = null;
            txt_diachi.Text = null;
            txt_chucvu.Text = null;
            txt_luong.Text = null;
            txt_tendangnhap.Text = null;
            txt_matkhau.Text = null;
            rb_nam.Checked = rb_nu.Checked = false;
            txt_sdt.Text = null;
            datetm_ngaysinh_nhanvien.Text = null;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_data_nhanvien();
        }

        private void tooltrp_refresh_nhanvien_Click(object sender, EventArgs e)
        {
            load_data_nhanvien();
        }

        int id_manhanvien = 0;int id_account = 0;
        private void datagrip_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_manhanvien = int.Parse(datagrip_nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString());// gán mã nhân viên mã tài khoản của nhân viên đó 
              


                txt_hoten.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                rb_nam.Checked = bool.Parse(datagrip_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString());
                rb_nu.Checked = !rb_nam.Checked;
                datetm_ngaysinh_nhanvien.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_diachi.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_sdt.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_chucvu.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_luong.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_tendangnhap.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[9].Value.ToString();
                txt_matkhau.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch (Exception)
            {

              
            }
           

        }

        private void datagrip_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void tooltrp_insert_nhanvien_Click(object sender, EventArgs e)
        {
            enable_control(true);
            btn_chucnang_nhanvien.Visible = true;
            btn_chucnang_nhanvien.Text = "Thêm mới nhân viên ";
            chucnang = "them";

        }
        string chucnang = null;
        private void btn_chucnang_nhanvien_Click(object sender, EventArgs e)
        {
            switch (chucnang)
            {
                case "them":
                    {
                        nhanvien nv = new nhanvien();
                        Account ac = new Account();
                        DataTable dt = ac.show_account();
                        List<DataRow> list_ac = dt.AsEnumerable().ToList();
                        foreach (var item in list_ac)
                        {
                            id_account =int.Parse( item[0].ToString()) +1 ;
                        }
                 
                        nv.hoten = txt_hoten.Text;
                        if (rb_nam.Checked) nv.gioitinh = true;
                        else nv.gioitinh = false;
                        nv.diachi = txt_diachi.Text;
                        nv.chucvu = txt_chucvu.Text;
                        nv.luong = int.Parse(txt_luong.Text);
                        nv.ngaysinh = DateTime.Parse(datetm_ngaysinh_nhanvien.Text);
                        nv.ngaysinh.ToShortDateString();
                        nv.sđt = int.Parse(txt_sdt.Text);
                        ac.username = txt_tendangnhap.Text;
                        ac.pass = txt_matkhau.Text;

                        if (nv.insert_nhanvien(nv,ac))
                        {
                            MessageBox.Show("Bạn vừa thêm thành công nhân viên " + nv.hoten.ToString() + " hoàn tất !");
                        }
                        else
                        {
                            MessageBox.Show("Thất bại ! Bạn chưa thể thêm thành công nhân viên vào hệ thống ! ");
                        }
                        load_data_nhanvien();
                        return;
                    }
                case "sua":
                    {
                        nhanvien nv = new nhanvien();
                        Account ac = new Account();
                        nv.id_nhanvien = id_manhanvien;
                        nv.hoten = txt_hoten.Text;
                        nv.gioitinh = rb_nam.Checked;
                        nv.chucvu = txt_chucvu.Text;
                        nv.diachi = txt_diachi.Text;
                        nv.ngaysinh = DateTime.Parse(datetm_ngaysinh_nhanvien.Text);
                        nv.ngaysinh.ToShortDateString();
                        nv.luong =int.Parse( txt_luong.Text);
                        nv.sđt = int.Parse(txt_sdt.Text);
                        ac.id_account = id_account;
                        ac.username = txt_tendangnhap.Text;
                        ac.pass = txt_matkhau.Text;
                        if (nv.update_nhanvien(nv, ac))
                        {
                            MessageBox.Show("Bạn vừa cập nhập thành công thông tin nhân viên " + nv.hoten.ToString() + " !");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhập thông tin thất bại ! Vui lòng thử lại ! ");
                        }
                        load_data_nhanvien();
                        return;
                    }
                case "xoa":
                    {
                        nhanvien nv = new nhanvien();
                        String text = "Bạn có muốn xóa nhân viên " + txt_hoten.Text + " không ? ";
                        string caption = " Xóa nhân viên ";
                        var resuit = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resuit==DialogResult.Yes)
                        {
                            if (nv.delete_nhanvien(id_manhanvien, id_account))
                            {
                                MessageBox.Show("Bạn vừa xóa thành công nhân viên " + txt_hoten.Text + " ra khỏi hệ thống ");

                            }
                            else
                            {
                                MessageBox.Show("Thất bại ! Bạn chưa thể xóa nhân viên " + txt_hoten.Text + " ra khỏi hệ thống","Thất bại ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            }
                        }
                        load_data_nhanvien();
                        return;
                        
                    }
                default:
                    break;
            }
          
        }

        private void tooltrp_update_nhanvien_Click(object sender, EventArgs e)
        {
            enable_control(true);
            btn_chucnang_nhanvien.Visible = true;
            btn_chucnang_nhanvien.Text = "Sửa thông tin nhân viên ";
            chucnang = "sua";
        }

        private void tooltrp_delete_Click(object sender, EventArgs e)
        {
            enable_control(true);
            btn_chucnang_nhanvien.Visible = true;
            btn_chucnang_nhanvien.Text = "Xóa nhân viên ";
            chucnang = "xoa";
        }

        private void tooltrp_search_nhanvien_Click(object sender, EventArgs e)
        {
          
            nhanvien nv = new nhanvien();
            int i = nv.search_nhanvien_theoten(tooltrp_textsearch_nhanvien.Text).Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Tìm được " + i.ToString() + " kết quả ! ");
                datagrip_nhanvien.DataSource = nv.search_nhanvien_theoten(tooltrp_textsearch_nhanvien.Text);
                tooltrp_textsearch_nhanvien.Text = null;
            }
            else
            {
                MessageBox.Show("Không có kết quả nào phù hợp !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                load_data_nhanvien();
            }
        }
    }
}
