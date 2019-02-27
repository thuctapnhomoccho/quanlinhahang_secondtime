using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using thuctapnhom_quanlinhahang.Object;
namespace thuctapnhom_quanlinhahang.Object
{
    class Logins
    {
     
        connects cn = new connects();
        public DataTable show_account(string user ,string pass)
        {
           
                DataTable dttb = new DataTable();
                if (cn.isConnect())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = cn.cnt;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"kiemtra_dangnhap";
                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                        
                        SqlDataAdapter adt = new SqlDataAdapter(cmd);
                        adt.Fill(dttb);
                    }
                    catch (Exception)
                    {


                    }


                }
                return dttb;
            
        }
    }
}
