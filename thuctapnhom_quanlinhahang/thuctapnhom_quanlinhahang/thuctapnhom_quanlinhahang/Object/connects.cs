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
    class connects
    {
        public SqlConnection cnt;
        string text_connect = @"Data Source=DESKTOP-AMTNAOM\SQLEXPRESS;Initial Catalog=quanlinhahang;Integrated Security=True";
        public connects()
        {
            cnt = new SqlConnection(text_connect);
        }
        public bool isConnect()
        {
            bool kp = false;
            try
            {
                cnt.Open();

                if (cnt.State == System.Data.ConnectionState.Open)
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
