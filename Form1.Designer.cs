namespace ThiThu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            tiệnÍchToolStripMenuItem = new ToolStripMenuItem();
            giảiPhươngTrìnhBậc2ToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            đăngKýMônHọcToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            lbInfo = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, tiệnÍchToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(74, 20);
            hệThốngToolStripMenuItem.Text = "Hệ Thống ";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(104, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // tiệnÍchToolStripMenuItem
            // 
            tiệnÍchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giảiPhươngTrìnhBậc2ToolStripMenuItem, địnhDạngToolStripMenuItem, đăngKýMônHọcToolStripMenuItem });
            tiệnÍchToolStripMenuItem.Name = "tiệnÍchToolStripMenuItem";
            tiệnÍchToolStripMenuItem.Size = new Size(60, 20);
            tiệnÍchToolStripMenuItem.Text = "Tiện Ích";
            // 
            // giảiPhươngTrìnhBậc2ToolStripMenuItem
            // 
            giảiPhươngTrìnhBậc2ToolStripMenuItem.Name = "giảiPhươngTrìnhBậc2ToolStripMenuItem";
            giảiPhươngTrìnhBậc2ToolStripMenuItem.Size = new Size(199, 22);
            giảiPhươngTrìnhBậc2ToolStripMenuItem.Text = "Giải Phương Trình Bậc 2";
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(199, 22);
            địnhDạngToolStripMenuItem.Text = "Định Dạng";
            // 
            // đăngKýMônHọcToolStripMenuItem
            // 
            đăngKýMônHọcToolStripMenuItem.Name = "đăngKýMônHọcToolStripMenuItem";
            đăngKýMônHọcToolStripMenuItem.Size = new Size(199, 22);
            đăngKýMônHọcToolStripMenuItem.Text = "Đăng Ký Môn Học";
            đăngKýMônHọcToolStripMenuItem.Click += đăngKýMônHọcToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giớiThiệuToolStripMenuItem, cậpNhậtToolStripMenuItem });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(63, 20);
            trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(130, 22);
            giớiThiệuToolStripMenuItem.Text = "Giới Thiệu ";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(130, 22);
            cậpNhậtToolStripMenuItem.Text = "Cập Nhật ";
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.BackColor = Color.FromArgb(128, 64, 64);
            lbInfo.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInfo.ForeColor = SystemColors.ButtonHighlight;
            lbInfo.Location = new Point(351, 180);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(94, 36);
            lbInfo.TabIndex = 2;
            lbInfo.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbInfo);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Đề Thi";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem tiệnÍchToolStripMenuItem;
        private ToolStripMenuItem giảiPhươngTrìnhBậc2ToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem đăngKýMônHọcToolStripMenuItem;
        private Label lbInfo;
    }
}
