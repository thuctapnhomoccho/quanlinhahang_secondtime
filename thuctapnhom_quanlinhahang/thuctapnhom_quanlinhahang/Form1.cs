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
        public void enable_control_nhanvien(bool bl)
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
            btn_huy_nhanvien.Visible = bl;
            btn_chucnang_nhanvien.Visible = bl;


        }
        public void load_data_nhanvien()
        {
          
            enable_control_nhanvien(false);
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
            // TODO: This line of code loads data into the 'quanlinhahangDataSet1.Loaibanan' table. You can move, or remove it, as needed.
            this.loaibananTableAdapter1.Fill(this.quanlinhahangDataSet1.Loaibanan);
            // TODO: This line of code loads data into the 'quanlinhahangDataSet.Loaibanan' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanlinhahangDataSet1.Loaibanan' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanlinhahangDataSet.ban_an' table. You can move, or remove it, as needed.
            load_data_nhanvien();
            load_data_banan();
            load_data_khachhang();
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
            enable_control_nhanvien(true);
            btn_chucnang_nhanvien.Visible = true;
            btn_chucnang_nhanvien.Text = "Thêm mới nhân viên ";
            chucnang = "them";

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
                        nv.ngaysinh=DateTime.Parse( nv.ngaysinh.ToShortDateString());
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
            enable_control_nhanvien(true);
            btn_chucnang_nhanvien.Visible = true;
            btn_chucnang_nhanvien.Text = "Sửa thông tin nhân viên ";
            chucnang = "sua";
        }

        private void tooltrp_delete_Click(object sender, EventArgs e)
        {
            enable_control_nhanvien(true);
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

      
        public void load_data_banan()
        {
            data_banan.RowHeadersVisible = false;
            banan ba = new banan();
            data_banan.DataSource = ba.show_banan();
            btn_chucnang_ban.Visible = false;
            btn_huy_banan.Visible = false;
            enable_control_banan(false);
            lb_idban.Visible = true;
            txt_id_banan.Visible = true;
            txt_chatlieuban.Text = null;
            txt_id_banan.Text = null;
            cb_sokhach_ban.Text = null;
            rb_active_ban.Checked = rb_empty_ban.Checked = false;
        }
        public void enable_control_banan(bool bl)
        {
            txt_id_banan.Enabled = bl;
            txt_chatlieuban.Enabled = bl;
            rb_active_ban.Enabled = bl;
            rb_empty_ban.Enabled = bl;
            cb_sokhach_ban.Enabled = bl;
            btn_huy_banan.Visible = bl;
            btn_chucnang_ban.Visible = bl;
        }
        
        private void tooltrp_insert_ban_Click(object sender, EventArgs e)
        {
            chucnang = "them";
         
            btn_chucnang_ban.Text = " Thêm bàn ăn ";
            enable_control_banan(true);
            txt_id_banan.Text = "";
            txt_chatlieuban.Text = "";
            rb_active_ban.Checked = rb_empty_ban.Checked = false;
            cb_sokhach_ban.Text = "Chọn số lượng khách tối đa của bàn ";
            lb_idban.Visible = false;
            txt_id_banan.Visible = false;
        }

        private void toooltrp_reset_ban_Click(object sender, EventArgs e)
        {
            load_data_banan();
            tool_cb_filter_ban.Text = null;
        }

        private void data_banan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id_banan.Text = data_banan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_chatlieuban.Text = data_banan.Rows[e.RowIndex].Cells[1].Value.ToString();
                rb_active_ban.Checked = bool.Parse(data_banan.Rows[e.RowIndex].Cells[2].Value.ToString());
                rb_empty_ban.Checked = !rb_active_ban.Checked;
                cb_sokhach_ban.Text = data_banan.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

               
            }
          
        }

        private void btn_chucnang_ban_Click(object sender, EventArgs e)
        {
            switch (chucnang)
            {
                case "them":
                    {
                       
                        banan ba = new banan();
                        ba.chatlieu = txt_chatlieuban.Text;
                        ba.tinhtrang = rb_active_ban.Checked;
                        ba.id_loaibanan =int.Parse( cb_sokhach_ban.SelectedValue.ToString());
                        if (ba.insert_banan(ba))
                        {
                            MessageBox.Show("Bạn vừa thêm mới một bàn ăn !");

                        }
                        else
                        {
                            MessageBox.Show("Thêm bàn ăn mới thất bại", "thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                       
                        load_data_banan();
                        return;
                    }
                case "sua":
                    {
                        banan ba = new banan();
                        ba.id_banan = int.Parse(txt_id_banan.Text);
                        ba.chatlieu = txt_chatlieuban.Text;
                        ba.tinhtrang = rb_active_ban.Checked;
                        ba.id_loaibanan = int.Parse(cb_sokhach_ban.SelectedValue.ToString());
                        if (ba.update_banan(ba))
                        {
                            MessageBox.Show("Bạn vừa sửa thành công bàn ăn số " + ba.id_banan.ToString() + " ! ");
                        }
                        else
                        {
                            MessageBox.Show("Sửa bàn ăn thất bại", "thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                        load_data_banan();
                        return;
                    }
                case "xoa":
                    {
                        banan ba = new banan();
                        
                        String text = "Bạn có muốn xóa ban an số  " + txt_id_banan.Text + " không ? ";
                        string caption = " Xóa bàn ăn ";
                        var resuit = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resuit == DialogResult.Yes)
                        {
                            if (ba.delete_banan(int.Parse(txt_id_banan.Text)))
                            {
                                MessageBox.Show("Bạn vừa xóa thành công bàn ăn số " + txt_id_banan.Text + " ra khỏi hệ thống ");

                            }
                            else
                            {
                                MessageBox.Show("Thất bại ! Bạn chưa thể xóa bàn ăn số  " + txt_id_banan.Text + " ra khỏi hệ thống", "Thất bại ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        load_data_banan();
                        return;
                    }
                default:
                    break;
            }
        }

        private void tooltrp_update_ban_Click(object sender, EventArgs e)
        {
           
           
            chucnang = "sua";
            btn_chucnang_ban.Visible = true;
            btn_chucnang_ban.Text = " Sửa bàn ăn ";
            enable_control_banan(true);
            txt_id_banan.Enabled = false;
        }

        private void tooltrp_delete_ban_Click(object sender, EventArgs e)
        {
            enable_control_banan(true);
            btn_chucnang_ban.Visible = true;
            btn_chucnang_ban.Text = " Xóa bàn ăn ";
            chucnang = "xoa";
        }

        private void btn_huy_banan_Click(object sender, EventArgs e)
        {
            load_data_banan();
        }

        private void btn_huy_nhanvien_Click(object sender, EventArgs e)
        {
            lb_idban.Visible = true;
            txt_id_banan.Visible = false;
            load_data_nhanvien();

        }

        private void toolStripButton5_Click(object sender, EventArgs e) // nút lọc bàn ăn 
        {
            int i = tool_cb_filter_ban.SelectedIndex;
            switch (i)
            {
                case 0:
                    {
                        banan ba = new banan();
                        if (ba.search_banan(false).Rows.Count > 0)
                        {
                            MessageBox.Show("Tìm được " + ba.search_banan(false).Rows.Count + " bàn ăn đang trống ");
                            data_banan.DataSource = null;
                            data_banan.DataSource = ba.search_banan(false);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bàn ăn nào đang trống ! ");
                            load_data_banan();
                        }
                       
                        return;
                    }
                case 1:
                    {
                        banan ba = new banan();
                        if (ba.search_banan(true).Rows.Count > 0)
                        {
                            MessageBox.Show("Tìm được " + ba.search_banan(true).Rows.Count + " bàn ăn đang sử dụng  ");
                            data_banan.DataSource = null;
                            data_banan.DataSource = ba.search_banan(true);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bàn ăn nào đang sử dụng ! ");
                            load_data_banan();
                        }
                       
                        return;
                    }
                default:
                    break;
            }
        }
        public void load_data_khachhang()
        {
            khachhang kh = new khachhang();
            datagrip_khachhang.DataSource = kh.show_khachhang();
            enable_control_khachhang(false);
            datagrip_khachhang.RowHeadersVisible = false;
            txt_hoten_khachhang.Text = null;
            rb_nam_khachhang.Checked = rb_nu_khachhang.Checked = false;
           
            txt_diachi.Text = null;
            txt_sdt_khachhang.Text = null;
            txt_sothe_khachhang.Text = null;
          
        }
        public void enable_control_khachhang(bool bl)
        {
            txt_hoten_khachhang.Enabled = bl;
            txt_sdt_khachhang.Enabled = bl;
            txt_sothe_khachhang.Enabled = bl;
            date_ngaysinh_khachhang.Enabled = bl;
            date_ngaysinh_khachhang.Text = null;
           
            txt_diachi_khachhang.Enabled = bl;
            btn_chucnang_khachhang.Visible = btn_huy_khachhang.Visible = bl;
            rb_nam_khachhang.Enabled = rb_nu_khachhang.Enabled = bl;

        }

        private void tooltrp_reset_khachhang_Click(object sender, EventArgs e)
        {
            load_data_khachhang();
        }

        private void tooltrp_insert_khachhang_Click(object sender, EventArgs e)
        {
            chucnang = "them";
            enable_control_khachhang(true);
            btn_chucnang_khachhang.Text = "Thêm khách hàng ";
        }
        int id_khachhang = 0;
        private void datagrip_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_khachhang = int.Parse(datagrip_khachhang.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_hoten_khachhang.Text = datagrip_khachhang.Rows[e.RowIndex].Cells[1].Value.ToString();
                rb_nam_khachhang.Checked=bool.Parse(datagrip_khachhang.Rows[e.RowIndex].Cells[2].Value.ToString());
                rb_nu_khachhang.Checked = !rb_nam_khachhang.Checked;
                date_ngaysinh_khachhang.Value=DateTime.Parse(datagrip_khachhang.Rows[e.RowIndex].Cells[3].Value.ToString());
                txt_diachi_khachhang.Text= datagrip_khachhang.Rows[e.RowIndex].Cells[4].Value.ToString();
               txt_sdt_khachhang.Text= datagrip_khachhang.Rows[e.RowIndex].Cells[5].Value.ToString();
               txt_sothe_khachhang.Text= datagrip_khachhang.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void btn_chucnang_khachhang_Click(object sender, EventArgs e)
        {
            switch (chucnang)
            {
                case "them":
                    {

                        khachhang kh = new khachhang();
                       kh.hoten  = txt_hoten_khachhang.Text;
                       kh.gioitinh= rb_nam_khachhang.Checked;
                       kh.ngaysinh = DateTime.Parse(date_ngaysinh_khachhang.Value.ToShortDateString());
                        kh.quequan = txt_diachi_khachhang.Text;
                        kh.sdt =int.Parse( txt_sdt_khachhang.Text);
                        kh.sothe =int.Parse( txt_sothe_khachhang.Text);
                        if (kh.insert_khachhang(kh))
                        {
                            MessageBox.Show("Bạn vừa thêm mới một khách hàng !");

                        }
                        else
                        {
                            MessageBox.Show("Thêm khách hàng mới thất bại", "thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                        load_data_khachhang();
                        return;
                    }
                case "sua":
                    {
                        khachhang kh = new khachhang();
                        kh.id = id_khachhang;
                        kh.hoten = txt_hoten_khachhang.Text;
                        kh.gioitinh = rb_nam_khachhang.Checked;
                        kh.quequan = txt_diachi_khachhang.Text;
                        kh.ngaysinh = DateTime.Parse( date_ngaysinh_khachhang.Value.ToShortDateString());
                        kh.sdt = int.Parse(txt_sdt_khachhang.Text);
                        kh.sothe = int.Parse(txt_sothe_khachhang.Text);
                        if (kh.update_khachhang(kh))
                        {
                            MessageBox.Show("Bạn vừa sửa thành công thông tin khách hàng  " + kh.hoten + " ! ");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin khách hàng thất bại thất bại", "thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                        load_data_khachhang();
                        return;
                    }
                case "xoa":
                    {
                        khachhang kh = new khachhang();

                        String text = "Bạn có muốn xóa khách hàng " + txt_hoten_khachhang.Text + " không ? ";
                        string caption = " Xóa khách hàng ";
                        var resuit = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resuit == DialogResult.Yes)
                        {
                            if (kh.delete_khachhang(id_khachhang))
                            {
                                MessageBox.Show("Bạn vừa xóa thành công bàn ăn số " + txt_hoten_khachhang.Text + " ra khỏi hệ thống ");

                            }
                            else
                            {
                                MessageBox.Show("Thất bại ! Bạn chưa thể xóa bàn ăn số  " + txt_hoten_khachhang.Text + " ra khỏi hệ thống", "Thất bại ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        load_data_khachhang();
                        return;
                    }
                default:
                    break;
            }
        }

        private void tooltrp_update_khachhang_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
            enable_control_khachhang(true);
            btn_chucnang_khachhang.Text = "Sửa khách hàng ";
        }

        private void tooltrp_delete_khachhang_Click(object sender, EventArgs e)
        {
            chucnang = "xoa";
            enable_control_khachhang(true);
            btn_chucnang_khachhang.Text = " Xóa khách hàng ";
        }

        private void btn_huy_khachhang_Click(object sender, EventArgs e)
        {
            load_data_khachhang();
        }

        private void tooltrp_search_khachhang_Click(object sender, EventArgs e)
        {
            khachhang kh = new khachhang();
            if (kh.search_khachhang(tooltrp_textsearch_khachhang.Text).Rows.Count > 0)
            {
                MessageBox.Show("Tìm được " + kh.search_khachhang(tooltrp_textsearch_khachhang.Text).Rows.Count + " khách hàng ! ");
                datagrip_khachhang.DataSource = kh.search_khachhang(tooltrp_textsearch_khachhang.Text);
            }
        }
    }
}
