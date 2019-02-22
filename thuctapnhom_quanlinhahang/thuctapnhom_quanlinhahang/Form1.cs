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

            
            
        }
        public void load_data_nhanvien()
        {
            btn_chucnang_nhanvien.Visible = false;
            enable_control(false);
            nhanvien nv = new nhanvien();
            datagrip_nhanvien.DataSource = nv.show_nhanvien();
            datagrip_nhanvien.RowHeadersVisible = false;
            txt_hoten.Text = null;
            txt_diachi.Text = null;
            txt_chucvu.Text = null;
            txt_luong.Text = null;
            txt_tendangnhap.Text = null;
            txt_matkhau.Text = null;
            rb_nam.Checked = rb_nu.Checked = false;
            txt_sdt.Text = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_data_nhanvien();
        }

        private void tooltrp_refresh_nhanvien_Click(object sender, EventArgs e)
        {
            load_data_nhanvien();
        }

       
        private void datagrip_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_hoten.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            rb_nam.Checked = bool.Parse(datagrip_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString());
            rb_nu.Checked = !rb_nam.Checked;
            txt_diachi.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_sdt.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_chucvu.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_luong.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_tendangnhap.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_matkhau.Text = datagrip_nhanvien.Rows[e.RowIndex].Cells[8].Value.ToString();

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
            if (chucnang == "them")
            {
                nhanvien nv = new nhanvien();
                Account ac = new Account();
                DataTable dt = ac.show_account();
                nv.id_account = dt.Rows.Count + 1;
                nv.hoten = txt_hoten.Text;
                if (rb_nam.Checked) nv.gioitinh = true;
                else nv.gioitinh = false;
                nv.diachi = txt_diachi.Text;
                nv.chucvu = txt_chucvu.Text;
                nv.luong = int.Parse(txt_luong.Text);
                nv.sđt = int.Parse(txt_sdt.Text);
                nv.username = txt_tendangnhap.Text;
                nv.pass = txt_matkhau.Text;

                if (nv.insert_nhanvien(nv))
                {
                    MessageBox.Show("Bạn vừa thêm thành công nhân viên " + nv.hoten.ToString() + " hoàn tất !");
                }
                else
                {
                    MessageBox.Show("Thất bại ! Bạn chưa thể thêm thành công nhân viên vào hệ thống ! ");
                }
                load_data_nhanvien();
            }
        }
    }
}
