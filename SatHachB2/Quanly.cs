using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachB2
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openpic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openpic.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }



        private void load_thisinh()
        {

            string cmd = "Select * from ThiSinh";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.connStr);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            dataThiSinh.DataSource = ds;
        }
        private void quảnLýThíSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_thisinh();
            pn_qlThiSinh.BringToFront();
        }

        private void danhSáchCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pn_qlcauhoi.BringToFront();
        }

        private void click_them(object sender, EventArgs e)
        {
           String namepic = openpic.SafeFileName;
            if (namepic.Equals("openFileDialog1")) namepic = "avatar.png";
            ThongTinThiSinh ts = new ThongTinThiSinh();
            if (ts.themthisinh(txt_sbd.Text, txt_Ho.Text, txt_ten.Text, datebirth.Text, rbtn_nam.Checked, txt_quoctich.Text, rtxtdiachi.Text, namepic, txtcmnd.Text))
            {
                pic_add.Image = Image.FromFile(@"system picture\complete.png");

            }
            else {
                pic_add.Image = Image.FromFile(@"system picture\fail.png");
            }
            pic_add.Show();
            load_thisinh();

        }
        private void click_pic(object sender, System.EventArgs e)
        {
            Stream myStream = null;
            openpic = new OpenFileDialog();

            openpic.InitialDirectory = @"\";
            openpic.Filter = "txt files (*.jpg)|*.txt|All files (*.*)|*.*";
            openpic.FilterIndex = 2;
            openpic.RestoreDirectory = true;

            if (openpic.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openpic.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            pic_qltsdt.Image = Image.FromFile(openpic.FileName);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            pic_edit.Hide();
            pic_del.Hide();
            pic_add.Hide();
            load_thisinh();
        }

        private void Hide_nofication(object sender, KeyEventArgs e)
        {
            pic_edit.Hide();
            pic_del.Hide();
            pic_add.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtcmnd.Text = "";
            txt_Ho.Text = "";
            txt_quoctich.Text = "";
            txt_sbd.Text = "";
            txt_ten.Text = "";
           
            pic_qltsdt.Image = Image.FromFile(@"\system picture\avatar.png");
             openpic.FileName = "openFileDialog1";



        }

        private void button3_Click(object sender, EventArgs e)
        {

            String namepic = openpic.SafeFileName;
            if (namepic.Equals("openFileDialog1")) namepic = "avatar.png";
            ThongTinThiSinh ts = new ThongTinThiSinh();
            if (ts.Suathisinh(txt_sbd.Text, txt_Ho.Text, txt_ten.Text, datebirth.Text, rbtn_nam.Checked, txt_quoctich.Text, rtxtdiachi.Text, namepic, txtcmnd.Text))
            {

                pic_edit.Image = Image.FromFile(@"system picture\complete.png");
            }
            else
            {
                pic_edit.Image = Image.FromFile(@"system picture\fail.png");
            }
            pic_edit.Show();
            load_thisinh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ThongTinThiSinh ts = new ThongTinThiSinh();
            if (ts.Xoathisinh(txt_sbd.Text))
            {

                pic_del.Image = Image.FromFile(@"system picture\complete.png");
            }
            else
            {
                pic_del.Image = Image.FromFile(@"system picture\fail.png");
            }
            pic_del.Show();
            load_thisinh();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void thêmCâuHỏiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pn_ThemCauHoi.BringToFront();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemCauHoi();
        }

        private void ThemCauHoi()
        {
            throw new NotImplementedException();
        }
    }
}
