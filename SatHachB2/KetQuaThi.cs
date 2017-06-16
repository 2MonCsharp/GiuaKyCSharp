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
    public partial class KetQuaThi : Form
    {
        public KetQuaThi()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KetQuaThi_Load(object sender, EventArgs e)
        {
            
            ThongTinThiSinh ts = new ThongTinThiSinh(Program.SBD);

            int KQ = SoCauDung();
            int CauDaLam = 30 - SoCauChuaLam();
            lb_hovaten.Text = ts.ho + " " + ts.ten;
            lb_gioiTinh.Text = ts.gioiTinh;
            if (KQ >= 26) lb_ketqua.Text ="Đậu"; else lb_ketqua.Text = "Rớt";
           
            lb_socaudung.Text =KQ.ToString();
            lb_QuocTich.Text = ts.quoctich;
            lb_ngaysinh.Text = ts.ngaysinh;
            lb_diaChi.Text = ts.diachi;
            lb_sCauDaLam.Text = CauDaLam.ToString();
            String filepath = @"imagets\" + ts.hinhanh;
            pictureBox1.Image = Image.FromFile(filepath.ToString());
        }
        int SoCauDung()
        {
            string cmd = "select * from SoCauDung('"+Program.SBD+"','"+Program.MBT+"') ";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.connStr);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return int.Parse(ds.Rows[0]["SoCauDung"].ToString());
           
           
        }
        int SoCauChuaLam()
        {
            string cmd = "select * from SoCauChuaLam('" + Program.SBD + "','" + Program.MBT + "') ";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.connStr);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            
            return (int)ds.Rows[0]["SoCauChuaLam"];
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            Program.thi.Hide();
            Program.start.Show();
            Close();
        }
    }
}
