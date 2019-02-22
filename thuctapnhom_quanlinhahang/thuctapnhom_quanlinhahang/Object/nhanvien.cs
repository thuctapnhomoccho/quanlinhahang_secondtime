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
        public int id_account;
        public string username;
        public string pass;
        public string hoten;
        public bool gioitinh;
        public string diachi;
        public int sđt;
        public string chucvu;
        public int luong;
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
        public bool insert_nhanvien(nhanvien nv)
        {
            bool kp = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn.cnt;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"insert_nhanvien";
                cmd.Parameters.AddWithValue("@id_account", nv.id_account);
                cmd.Parameters.AddWithValue("@username", nv.username);
                cmd.Parameters.AddWithValue("@pass", nv.pass);
                cmd.Parameters.AddWithValue("@hoten", nv.hoten);
                cmd.Parameters.AddWithValue("@gioitinh", nv.gioitinh);
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
    }
}
