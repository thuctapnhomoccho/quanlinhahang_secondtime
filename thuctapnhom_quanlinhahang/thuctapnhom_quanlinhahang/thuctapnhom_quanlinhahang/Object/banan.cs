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
    class banan
    {
        public int id_banan=0;
        public string chatlieu=null;
        public bool tinhtrang=false;
        public int id_loaibanan=0;
        connects cn = new connects();
        public DataTable show_banan()
        {
            DataTable dttb = new DataTable();
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"showbanan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    adt.Fill(dttb);
                }
                catch (Exception)
                {

                  
                }
              

            }
             return dttb;
        }
        public bool insert_banan(banan ba)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"insert_banan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@chatlieuu", ba.chatlieu);
                    cmd.Parameters.AddWithValue("@tinhtrang", ba.tinhtrang);
                    cmd.Parameters.AddWithValue("@id_loaibanan", ba.id_loaibanan);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public bool update_banan(banan ba)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"update_banan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ba.id_banan);
                    cmd.Parameters.AddWithValue("@chatlieuu", ba.chatlieu);
                    cmd.Parameters.AddWithValue("@tinhtrang", ba.tinhtrang);
                    cmd.Parameters.AddWithValue("@id_loaibanan", ba.id_loaibanan);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) kp = true;
                }
                catch (Exception)
                {


                }

            }
            return kp;
        }
        public bool delete_banan(int a)
        {
            bool kp = false;
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"delete_banan";
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
        public DataTable search_banan(bool a)
        {
            DataTable kp = new DataTable();
            if (cn.isConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn.cnt;
                    cmd.CommandText = @"search_banan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@loc", a);
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
