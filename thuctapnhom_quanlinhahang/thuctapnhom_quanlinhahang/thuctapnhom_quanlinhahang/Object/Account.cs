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
    class Account
    {
        public int id_account;
        public string username;
        public string pass;
        connects cn = new connects();
        public DataTable show_account()
        {
            DataTable dttb = new DataTable();
            if (cn.isConnect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn.cnt;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select * from Account";
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dttb);
            }
            return dttb;
        }
    }
}
