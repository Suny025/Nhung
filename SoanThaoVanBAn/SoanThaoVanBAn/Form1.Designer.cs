namespace Lab03_02
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb_vanban = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cb_Font = new System.Windows.Forms.ToolStripComboBox();
            this.cb_Size = new System.Windows.Forms.ToolStripComboBox();
            this.btn_bold = new System.Windows.Forms.ToolStripButton();
            this.btn_italic = new System.Windows.Forms.ToolStripButton();
            this.btn_underline = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_vanban
            // 
            this.rtb_vanban.Location = new System.Drawing.Point(7, 60);
            this.rtb_vanban.Name = "rtb_vanban";
            this.rtb_vanban.Size = new System.Drawing.Size(765, 308);
            this.rtb_vanban.TabIndex = 0;
            this.rtb_vanban.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.địnhDangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // mnuNew
            // 
            this.mnuNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuNew.Image")));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(285, 26);
            this.mnuNew.Text = "Tạo văn bản mới";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpen.Image")));
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(285, 26);
            this.mnuOpen.Text = "Mở tập tin";
            // 
            // mnuSave
            // 
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(285, 26);
            this.mnuSave.Text = "Lưu nội dung văn bản";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // địnhDangToolStripMenuItem
            // 
            this.địnhDangToolStripMenuItem.Name = "địnhDangToolStripMenuItem";
            this.địnhDangToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.địnhDangToolStripMenuItem.Text = "Định dang";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.cb_Font,
            this.cb_Size,
            this.btn_bold,
            this.btn_italic,
            this.btn_underline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // cb_Font
            // 
            this.cb_Font.Name = "cb_Font";
            this.cb_Font.Size = new System.Drawing.Size(121, 28);
            this.cb_Font.Text = "Tahoma";
            this.cb_Font.Click += new System.EventHandler(this.cb_Font_Click);
            // 
            // cb_Size
            // 
            this.cb_Size.Name = "cb_Size";
            this.cb_Size.Size = new System.Drawing.Size(121, 28);
            this.cb_Size.Text = "14";
            this.cb_Size.Click += new System.EventHandler(this.cb_Size_Click);
            // 
            // btn_bold
            // 
            this.btn_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_bold.Image = ((System.Drawing.Image)(resources.GetObject("btn_bold.Image")));
            this.btn_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(29, 25);
            this.btn_bold.Text = "toolStripButton3";
            this.btn_bold.Click += new System.EventHandler(this.btn_bold_Click_1);
            // 
            // btn_italic
            // 
            this.btn_italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_italic.Image = ((System.Drawing.Image)(resources.GetObject("btn_italic.Image")));
            this.btn_italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_italic.Name = "btn_italic";
            this.btn_italic.Size = new System.Drawing.Size(29, 25);
            this.btn_italic.Text = "toolStripButton4";
            this.btn_italic.Click += new System.EventHandler(this.btn_italic_Click_1);
            // 
            // btn_underline
            // 
            this.btn_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_underline.Image = ((System.Drawing.Image)(resources.GetObject("btn_underline.Image")));
            this.btn_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Size = new System.Drawing.Size(29, 25);
            this.btn_underline.Text = "toolStripButton5";
            this.btn_underline.Click += new System.EventHandler(this.btn_underline_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 380);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtb_vanban);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn Thảo Văn Bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_vanban;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhDangToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox cb_Font;
        private System.Windows.Forms.ToolStripComboBox cb_Size;
        private System.Windows.Forms.ToolStripButton btn_bold;
        private System.Windows.Forms.ToolStripButton btn_italic;
        private System.Windows.Forms.ToolStripButton btn_underline;
    }
}

