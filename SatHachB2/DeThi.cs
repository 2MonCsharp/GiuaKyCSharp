using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatHachB2
{
    class DeThi
    {
        private DataTable ds;
        public DeThi()
        {
            string cmd = "SELECT* FROM phan1 union SELECT* FROM phan2  union SELECT* FROM phan3 union SELECT* FROM phan4  union  SELECT* FROM phan5  union  SELECT* FROM phan6";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.connStr);
             ds = new DataTable();
            adap.Fill(ds);
            

        }
       public DataTable getDethi()
        {
            return ds;
        }
        

    }
}
