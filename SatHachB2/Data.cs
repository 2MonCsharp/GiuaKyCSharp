using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SatHachB2
{



    public class Data
    {
        DataTable DeThi()
        {
            string cmd = "SELECT top 30 FROM CauHoi";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.connStr);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }

        
    }
}
