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
    public partial class Thi : Form
    {
        List<PhieuTraLoi> listptl = new List<PhieuTraLoi>();

        public Thi()
        {
            InitializeComponent();
        }

        protected int phut, giay;

        protected void Startnow(object sender, EventArgs e)
        {
            phut = 30;
            giay = 0;
           
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1800;
            progressBar1.Value = 1800;
            progressBar1.Step = -1;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (phut > 0)
            {
                if (giay > 0)
                {
                    giay--;
                    progressBar1.PerformStep();
                }
                else
                {
                    giay = 59;
                    phut--;
                   
                    
                }
                String g = giay.ToString();
                String p = phut.ToString();
                if (giay < 10) g = "0" + g;
                if (phut < 10) g = "0" + p;
                this.lb_timer.Text = p + ":" + g;

            }

            else
            {
                if (phut == 0 && giay == 0)
                {
                    timer1.Stop();
                    thubai();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void setdethi()
        {
            DeThi dethi = new DeThi();
            this.dethi = dethi.getDethi();
        }
        private void Thi_Load(object sender, EventArgs e)
        {
            this.CauDaLam = 0;
            if (dethi == null) setdethi();
            lb_Qname.Text = "Câu hỏi: " + (CauDangLam + 1);
            //      lb_fullname.Text = Program.Hoten;
        
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
            int i = 0;
            foreach (DataRow row in this.dethi.Rows)
            {

                String myValue = row["SoDA"].ToString();
                String msch = row["MsCauHoi"].ToString();


                 ptl = new PhieuTraLoi();
                pn_DeThi.Controls.Add(ptl.gbx("cau" + (i + 1).ToString(), int.Parse(myValue), (i + 1).ToString(), msch));
                listptl.Add(ptl);
                i++;
            }
            loadcauhoi(this.CauDangLam);
            listptl[CauDangLam].setBackColorCDL();

        }


        private void loadcauhoi(int i)
        {
            if (i <= 29)
            {
                DataRow row = dethi.Rows[i];
                String myValue = row["MsCauHoi"].ToString();
                myValue = myValue.Trim();
                string filepath = @"image\" + myValue + ".JPG";

                pictureBox1.Image = Image.FromFile(filepath.ToString());

            }
        }
        private void thubai()
        {
            SqlConnection connDB = new SqlConnection(Program.connStr);
            connDB.Open();
            String sqlcmd = "";
            for (int i = 0; i < 30; i++)
            {

                string MsBaiThi = Program.MBT;
                string MSThiSinh = Program.SBD;
                string MsCauHoi = listptl[i].getMsCH();
                string DapAnofTS = listptl[i].getDapAnTS();
                sqlcmd = "insert into BaiThi values ('" + MsBaiThi + "','" + MSThiSinh + "','" + MsCauHoi + "','" + DapAnofTS + "');";

                Console.Write(sqlcmd);
                SqlCommand sqlCmd = new SqlCommand(sqlcmd, connDB);
                try { sqlCmd.ExecuteNonQuery(); }
                catch { }



            }
            connDB.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            thubai();
            Program.ketquathi = new KetQuaThi();
            Program.ketquathi.Show();

        }



       

        private void lb_info1_Click(object sender, EventArgs e)
        {

        }


        private void keyup(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        if (CauDangLam > 0)
                        {
                            listptl[CauDangLam].setBackColor();
                            CauDangLam--;
                            listptl[CauDangLam].setBackColorCDL();
                            loadcauhoi(this.CauDangLam);
                            lb_Qname.Text = "Câu hỏi: " + (CauDangLam + 1);
                      

                        }
                        break;
                    }
                case Keys.Down:
                    {

                        if (CauDangLam < 29)
                        {
                            listptl[CauDangLam].setBackColor();
                            CauDangLam++;
                            listptl[CauDangLam].setBackColorCDL();
                            loadcauhoi(this.CauDangLam);
                            lb_Qname.Text = "Câu hỏi: " + (CauDangLam + 1);
                      
                        }
                        break;
                    }
                case Keys.Left:
                    {
                        if (CauDangLam > 14 && CauDangLam <= 29)
                        {
                            listptl[CauDangLam].setBackColor();
                            CauDangLam -= 15;
                            listptl[CauDangLam].setBackColorCDL();
                            loadcauhoi(this.CauDangLam);
                            lb_Qname.Text = "Câu hỏi: " + (CauDangLam + 1);
                         
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if (CauDangLam < 15 && CauDangLam >= 0)
                        {
                            listptl[CauDangLam].setBackColor();
                            CauDangLam += 15;
                            listptl[CauDangLam].setBackColorCDL();
                            loadcauhoi(this.CauDangLam);
                            lb_Qname.Text = "Câu hỏi: " + (CauDangLam + 1);
                            
                        }
                        break;
                    }
            }





        }




        private int CauDangLam = 0;
        public int CauDaLam { get; set; }
        private void Anserkey(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1: { listptl[CauDangLam].daocheck(listptl[CauDangLam].getcb1()); break; }
                case Keys.NumPad2: { listptl[CauDangLam].daocheck(listptl[CauDangLam].getcb2()); break; }
                case Keys.NumPad3: { if (listptl[CauDangLam].getsda() >= 3) listptl[CauDangLam].daocheck(listptl[CauDangLam].getcb3()); break; }
                case Keys.NumPad4: { if (listptl[CauDangLam].getsda() >= 4) listptl[CauDangLam].daocheck(listptl[CauDangLam].getcb4()); break; }
            }
            
        }

        private DataTable dethi;
    }
}
