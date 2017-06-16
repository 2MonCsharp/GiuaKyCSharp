using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachB2
{
    class PhieuTraLoi
    {
        public void setBackColorCDL()
        {
            gb.BackColor = System.Drawing.Color.Red;
            gb.BorderColor = Color.Red;
        }
        public void setBackColor()
        {
         
                gb.BackColor = System.Drawing.Color.Orange;
            if (cb1.Checked == false && cb2.Checked == false && cb3.Checked == false && cb4.Checked == false)
            {
                gb.BackColor = Color.Silver;
                gb.BorderColor = Color.Silver;
            }
            else
            {
                gb.BackColor = Color.Orange;
                gb.BorderColor = Color.Orange;

            }
        }
        public GroupBox gbx(String name, int s, string i, string msch)
        {
            this.Name = int.Parse(i);
            this.sda = s;
            this.MsCauHoi = msch;

            // gb
            // 
            if (s == 2)
            {   gb.Controls.Add(cb1);
                gb.Controls.Add(cb2);
               
            }
            if (s == 3)
            {
                gb.Controls.Add(cb1);
                gb.Controls.Add(cb2);
                gb.Controls.Add(cb3);
            }
            if (s == 4)
            {   gb.Controls.Add(cb1);
                gb.Controls.Add(cb2);
                gb.Controls.Add(cb3);
                gb.Controls.Add(cb4);
            }


            gb.Location = new System.Drawing.Point(219, 44);
            gb.Margin = new System.Windows.Forms.Padding(1,1,1,1);
            gb.Name = name;
            gb.Padding = new System.Windows.Forms.Padding(1,1,1,1);
            gb.Size = new System.Drawing.Size(120, 45);
            gb.TabIndex = 7;
            gb.TabStop = false;
            gb.Text = i;
            gb.BorderColor = Color.Silver;
            gb.BackColor = Color.Silver;


            // 
            // cb1
            // 
            cb1.AutoSize = true;
            cb1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            cb1.Location = new System.Drawing.Point(15, 13);
            cb1.Margin = new System.Windows.Forms.Padding(0);
            cb1.Name = "cb1";
            cb1.Size = new System.Drawing.Size(17, 31);
            cb1.TabIndex = 0;
            cb1.Text = "1";
            cb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cb1.UseVisualStyleBackColor = true;
            cb1.CheckedChanged += delegate (object sender, EventArgs e)
             {
                 
                 CheckBox b = new CheckBox();
                 b = (CheckBox)sender;
                 if (b.Checked == true)
                 {
                     gb.BackColor = Color.Orange;
                     gb.BorderColor = Color.Orange;

                 }
             };
            // 
            // cb2
            // 
            cb2.AutoSize = true;
            cb2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            cb2.Location = new System.Drawing.Point(35, 13);
            cb2.Name = "cb2";
            cb2.Size = new System.Drawing.Size(17, 31);
            cb2.TabIndex = 1;
            cb2.Text = "2";
            cb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cb2.UseVisualStyleBackColor = true;
            cb2.CheckedChanged += delegate (object sender, EventArgs e)
            {
               
                CheckBox b = new CheckBox();
                b = (CheckBox)sender;
                if (b.Checked == true)
                {
                    gb.BackColor = Color.Orange;
                    gb.BorderColor = Color.Orange;

                }
            };
            // 
            // cb3
            // 
            cb3.AutoSize = true;
            cb3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            cb3.Location = new System.Drawing.Point(58, 13);
            cb3.Name = "cb3";
            cb3.Size = new System.Drawing.Size(17, 31);
            cb3.TabIndex = 2;
            cb3.Text = "3";
            cb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cb3.UseVisualStyleBackColor = true;
            cb3.CheckedChanged += delegate (object sender, EventArgs e)
            {
                
                CheckBox b = new CheckBox();
                b = (CheckBox)sender;
                if (b.Checked == true)
                {
                    gb.BackColor = Color.Orange;
                    gb.BorderColor = Color.Orange;

                }

            };
            // 
            // cb4
            // 
            cb4.AutoSize = true;
            cb4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            cb4.Location = new System.Drawing.Point(81, 13);
            cb4.Name = "cb4";
            cb4.Size = new System.Drawing.Size(17, 31);
            cb4.TabIndex = 3;
            cb4.Text = "4";
            cb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cb4.UseVisualStyleBackColor = true;
            cb4.CheckedChanged += delegate (object sender, EventArgs e)
            {

                CheckBox b = new CheckBox();
                b = (CheckBox)sender;
                if (b.Checked == true)
                {
                    gb.BackColor = Color.Orange;
                    gb.BorderColor= Color.Orange;

                }
            };
            return gb;
        }

        private void setDapAnTS()
        {
            if (cb1.Checked == true) DapAnTS = "1";
            if (cb2.Checked == true)
                if (DapAnTS.Equals("")) DapAnTS = "2"; else DapAnTS += ",2";
            if (cb3.Checked == true)
                if (DapAnTS.Equals("")) DapAnTS = "3"; else DapAnTS += ",3";
            if (cb4.Checked == true)
                if (DapAnTS.Equals("")) DapAnTS = "4"; else DapAnTS += ",4";
            if (cb1.Checked == false && cb2.Checked == false && cb3.Checked == false && cb4.Checked == false)
            {
                DapAnTS = "";

              
            }
        }
        public String getDapAnTS()
        {
            setDapAnTS();
            return DapAnTS;
        }
        public String getMsCH()
        {
            return MsCauHoi;
        }
      
        public void daocheck( object b)
        {
            CheckBox cb = (CheckBox)b;
            if (cb.Checked == true) cb.Checked = false;
            else
                cb.Checked = true;
        }
        public CheckBox getcb1()
        {
            return cb1;
        }
        public CheckBox getcb2()
        {
            return cb2;
        }
        public CheckBox getcb3()
        {
            return cb3;
        }
        public CheckBox getcb4()
        {
            return cb4;
        }
       public int getsda()
        {
            return sda;
        }
        MyGroupBox gb = new MyGroupBox();
        CheckBox cb1 = new CheckBox();
        CheckBox cb2 = new CheckBox();
        CheckBox cb3 = new CheckBox();
        CheckBox cb4 = new CheckBox();
        public int Name { get; set; }
        int sda;
        String MsCauHoi;
        String DapAnTS="";
        public event EventHandler Click;
    }
}
