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
    class Dsmonans
    {
        public int id_hoadon;
        public int id_monan;
        public int soluong;
        connects cn = new connects();
        public DataTable show_dsmonan(int id)
        {
            DataTable dttb = new DataTable();
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"show_dsmonan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_hoadon", id);
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    adt.Fill(dttb);
                }
                catch (Exception)
                {


                }


            }
            return dttb;
        }
        public bool insert_monan( Dsmonans ma)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"insert_chitietmonan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_hoadon",ma.id_hoadon );
                    cmd.Parameters.AddWithValue("@id_monan", ma.id_monan);
                    cmd.Parameters.AddWithValue("@soluong", ma.soluong);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public bool update_dsmonan(Dsmonans ma)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"update_chitietmonan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_hoadon", ma.id_hoadon);
                    cmd.Parameters.AddWithValue("@id_monan", ma.id_monan);
                    cmd.Parameters.AddWithValue("@soluong", ma.soluong);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                  
                }
                catch (Exception)
                {


                }
                finally
                {
                    cn.cnt.Close();
                }

            }
            return kp;
        }
        public bool delete_monan(int id_hoadon,int id_monan)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"delete_monan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_hoadon", id_hoadon);
                    cmd.Parameters.AddWithValue("@id_monan", id_monan);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public DataTable search_monan_theo_idloaimonan(int a)
        {
            DataTable kp = new DataTable();
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"search_monan_theo_idloaimonan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_loaimonan", a);
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
        public DataTable tinhtien (int a)
        {
            DataTable kp = new DataTable();
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"tinhtien";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_hoadon", a);
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

