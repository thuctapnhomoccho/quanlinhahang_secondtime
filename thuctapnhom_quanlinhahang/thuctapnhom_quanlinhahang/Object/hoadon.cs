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
    class hoadon
    {

        connects cn = new connects();
        public DataTable showhoadon()
        {
            DataTable kp = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn.cnt;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"showhoadon";
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = cmd;
            kp = new DataTable();
            adt.Fill(kp);

            return kp;
        }
    }
}
