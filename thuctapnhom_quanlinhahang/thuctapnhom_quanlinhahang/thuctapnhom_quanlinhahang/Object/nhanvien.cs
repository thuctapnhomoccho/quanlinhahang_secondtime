using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace thuctapnhom_quanlinhahang.Object
{
    class nhanvien
    {
       
        public int id_nhanvien;
        public string hoten;
        public bool gioitinh;
        public DateTime ngaysinh;
        public string diachi;
        public int sđt;
        public string chucvu;
        public int luong;
        public int id_account=0;
        connects cn = new connects();
        public DataTable show_nhanvien()
        {
            DataTable dttb = new DataTable();
            if (cn.isConnect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn.cnt;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"show_nhanvien";
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dttb);
            }
            return dttb;
        }
        public bool insert_nhanvien(nhanvien nv,Account ac)
        {
            bool kp = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn.cnt;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"insert_nhanvien";
                cmd.Parameters.AddWithValue("@id_account", ac.id_account);
                cmd.Parameters.AddWithValue("@username", ac.username);
                cmd.Parameters.AddWithValue("@pass", ac.pass);
                cmd.Parameters.AddWithValue("@hoten", nv.hoten);
                cmd.Parameters.AddWithValue("@gioitinh", nv.gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.ngaysinh);
                cmd.Parameters.AddWithValue("@diachi", nv.diachi);
                cmd.Parameters.AddWithValue("@sdt", nv.sđt);
                cmd.Parameters.AddWithValue("@chucvu", nv.chucvu);
                cmd.Parameters.AddWithValue("@luong", nv.luong);
                cn.cnt.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    kp = true;
                }

            }
            catch (Exception)
            {

            }


            return kp;

        }
        public bool update_nhanvien(nhanvien nv,Account ac)
        {
            bool kp = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn.cnt;
                cmd.CommandText = @"update_nhanvien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_nhanvien", nv.id_nhanvien);
                cmd.Parameters.AddWithValue("@hoten", nv.hoten);
                cmd.Parameters.AddWithValue("@gioitinh", nv.gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.ngaysinh);
                cmd.Parameters.AddWithValue("@diachi", nv.diachi);
                cmd.Parameters.AddWithValue("@sdt", nv.sđt);
                cmd.Parameters.AddWithValue("@chucvu", nv.chucvu);
                cmd.Parameters.AddWithValue("@luong", nv.luong);
                cmd.Parameters.AddWithValue("@id_account", ac.id_account);
                cmd.Parameters.AddWithValue("@tentk", ac.username);
                cmd.Parameters.AddWithValue("@matkhau", ac.pass);
                cn.cnt.Open();
               int i= cmd.ExecuteNonQuery();
                if (i > 0) kp = true;
            }
            catch (Exception)
            {

              
            }
            return kp;
        }
        public bool delete_nhanvien(int id_nv, int id_ac)
        {
            bool kp = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn.cnt;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"delete_nhanvien";
                cmd.Parameters.AddWithValue("@id_nhanvien", id_nv);
                cmd.Parameters.AddWithValue("@id_account", id_ac);
                cn.cnt.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) kp = true;
                
            }
            catch (Exception)
            {

                
            }
            return kp;
        }
        public DataTable search_nhanvien_theoid(int id)
        {
            DataTable dttd = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn.cnt;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select * from nhanvien where id_nhanvien = " + id.ToString();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dttd);
            }
            catch (Exception)
            {

             
            }
            return dttd;
        }
        public DataTable search_nhanvien_theoten(string text)
        {
            DataTable dttd = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn.cnt;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"search_nhanvien_ten";
                cmd.Parameters.AddWithValue("@ten", text);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dttd);
            }
            catch (Exception)
            {


            }
            return dttd;
        }
    }
}
