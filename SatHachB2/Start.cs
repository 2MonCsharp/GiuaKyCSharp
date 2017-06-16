using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachB2
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private bool isSBDtrue()
        {
            string cmd = "select * from ThiSinh where MsThiSinh='" + Program.SBD + "'";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.connStr);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            if (ds.Rows.Count == 1)
            {
                cmd = "select * from DotThi where MaBT='" + Program.MBT + "'";
                adap = new SqlDataAdapter(cmd, Program.connStr);
                ds = new DataTable();
                adap.Fill(ds);
                if (ds.Rows.Count == 1) {
                    cmd = "select * from KiemtraMBT('" + Program.SBD + "','" + Program.MBT + "') ";
                   adap = new SqlDataAdapter(cmd, Program.connStr);
                    ds = new DataTable();
                    adap.Fill(ds);

                    return (bool)ds.Rows[0]["IsChuaLam"];

                      }
            }
            return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Program.MBT = lb_MBT.Text;
            Program.SBD = lb_sbd.Text;

            if (isSBDtrue())
            {
                Program.xacnhan = new XacNhan();
                Program.xacnhan.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Thông tin sai.\n Xin mời nhập lại.","Thông Báo");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLy QL = new QuanLy();
            QL.Show();
        }
    }
}
