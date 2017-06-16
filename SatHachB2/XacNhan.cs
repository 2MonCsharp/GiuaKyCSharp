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
    public partial class XacNhan : Form
    {
        public XacNhan()
        {
            InitializeComponent();
        }

        private void XacNhan_Load(object sender, EventArgs e)
        {
          
            ThongTinThiSinh ts = new ThongTinThiSinh(Program.SBD);
     
            
                
                lb_hovaten.Text = ts.ho + " " + ts.ten;
                lb_gioiTinh.Text = ts.gioiTinh;

                lb_QuocTich.Text = ts.quoctich;
                lb_ngaysinh.Text = ts.ngaysinh;
                lb_diaChi.Text = ts.diachi;
            string filepath = @"imagets\" + ts.hinhanh;

            pictureBox1.Image = Image.FromFile(filepath.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateXN();
            Program.thi = new SatHachB2.Thi();
            Program.thi.Show();
            this.Hide();
        }

        private void UpdateXN()
        {
            SqlConnection connDB = new SqlConnection(Program.connStr);
            connDB.Open();
            string cmd = "UPDATE ThiSinh SET PhanHoi='" + rtb_phanHoi.Text + "' WHERE MsThiSinh='" + Program.SBD + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
    }
}
