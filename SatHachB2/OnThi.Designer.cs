namespace SatHachB2
{
    partial class OnThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiThửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.câuTrắcNghiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chủĐềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_thiThu = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thiThửToolStripMenuItem,
            this.câuTrắcNghiệmToolStripMenuItem,
            this.chủĐềToolStripMenuItem});
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // thiThửToolStripMenuItem
            // 
            this.thiThửToolStripMenuItem.Name = "thiThửToolStripMenuItem";
            this.thiThửToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thiThửToolStripMenuItem.Text = "Thi thử";
            // 
            // câuTrắcNghiệmToolStripMenuItem
            // 
            this.câuTrắcNghiệmToolStripMenuItem.Name = "câuTrắcNghiệmToolStripMenuItem";
            this.câuTrắcNghiệmToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.câuTrắcNghiệmToolStripMenuItem.Text = "450 câu trắc nghiệm";
            // 
            // chủĐềToolStripMenuItem
            // 
            this.chủĐềToolStripMenuItem.Name = "chủĐềToolStripMenuItem";
            this.chủĐềToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.chủĐềToolStripMenuItem.Text = "Chủ đề";
            // 
            // pn_thiThu
            // 
            this.pn_thiThu.Location = new System.Drawing.Point(0, 27);
            this.pn_thiThu.Name = "pn_thiThu";
            this.pn_thiThu.Size = new System.Drawing.Size(1334, 745);
            this.pn_thiThu.TabIndex = 1;
            // 
            // OnThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 608);
            this.Controls.Add(this.pn_thiThu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OnThi";
            this.Text = "Ôn thi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiThửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem câuTrắcNghiệmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chủĐềToolStripMenuItem;
        private System.Windows.Forms.Panel pn_thiThu;
    }
}