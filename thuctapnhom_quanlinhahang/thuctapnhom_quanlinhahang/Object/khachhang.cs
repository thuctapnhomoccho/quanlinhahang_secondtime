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
    class khachhang
    {
        public int id=0;
        public string hoten=null;
        public bool gioitinh=false;
        public DateTime ngaysinh=DateTime.Now;
        public int sdt=0;
        public int sothe=0;
        public string quequan=null;
        connects cn = new connects();
        public DataTable show_khachhang()
        {
            DataTable dttb = new DataTable();
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"showkhachhang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    adt.Fill(dttb);
                }
                catch (Exception)
                {


                }
                finally
                {
                    cn.cnt.Close();
                }


            }
            return dttb;
        }
        public bool insert_khachhang(khachhang kh)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"themkhachhang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ten", kh.hoten);
                    cmd.Parameters.AddWithValue("@gioitinh", kh.gioitinh);
                    cmd.Parameters.AddWithValue("@ngaysinh", kh.ngaysinh);
                    cmd.Parameters.AddWithValue("@diachi", kh.quequan);
                    cmd.Parameters.AddWithValue("@phone", kh.sdt);
                    cmd.Parameters.AddWithValue("@card", kh.sothe);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public bool update_khachhang(khachhang kh)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"update_khachhang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id",kh.id );
                    cmd.Parameters.AddWithValue("@ten", kh.hoten);
                    cmd.Parameters.AddWithValue("@gioitinh", kh.gioitinh);
                    cmd.Parameters.AddWithValue("@ngaysinh", kh.ngaysinh);
                    cmd.Parameters.AddWithValue("@diachi", kh.quequan);
                    cmd.Parameters.AddWithValue("@phone", kh.sdt);
                    cmd.Parameters.AddWithValue("@card", kh.sothe);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public bool delete_khachhang(int a)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"delete_khachhang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", a);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public DataTable search_khachhang(string a)
        {
            DataTable kp = new DataTable();
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"seach_khachhang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", a);
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    adt.Fill(kp);

                    cn.cnt.Close();

                }
                catch (Exception)
                {


                }

            }


            return kp;
        }

    }
}
