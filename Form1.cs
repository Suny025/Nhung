using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        string currentFile = "";   // lưu đường dẫn file
        bool isSaved = true;      // file đã lưu hay chưa

        public Form1()
        {
            InitializeComponent();
        }

        // ---------------------------- FORM LOAD ----------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load tất cả font hệ thống
            foreach (FontFamily f in new InstalledFontCollection().Families)
            {
                cb_Font.Items.Add(f.Name);
            }

            // Load size
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
                cb_Size.Items.Add(s);

            // Thiết lập mặc định
            cb_Font.Text = "Tahoma";
            cb_Size.Text = "14";
            rtb_vanban.Font = new Font("Tahoma", 14);

            
        }

        // ---------------------------- ĐỊNH DẠNG CHỮ ----------------------------

        
        private void btn_bold_Click_1(object sender, EventArgs e)
        {
            if (rtb_vanban.SelectionFont == null) return;

            Font f = rtb_vanban.SelectionFont;
            FontStyle style = f.Style ^ FontStyle.Bold;
            rtb_vanban.SelectionFont = new Font(f.FontFamily, f.Size, style);

        }

        private void btn_italic_Click_1(object sender, EventArgs e)
        {
            if (rtb_vanban.SelectionFont == null) return;

            Font f = rtb_vanban.SelectionFont;
            FontStyle style = f.Style ^ FontStyle.Italic;
            rtb_vanban.SelectionFont = new Font(f.FontFamily, f.Size, style);
        }

        private void btn_underline_Click_1(object sender, EventArgs e)
        {
            if (rtb_vanban.SelectionFont == null) return;

            Font f = rtb_vanban.SelectionFont;
            FontStyle style = f.Style ^ FontStyle.Underline;
            rtb_vanban.SelectionFont = new Font(f.FontFamily, f.Size, style);
        }

        private void cb_Size_Click(object sender, EventArgs e)
        {

        }

        private void cb_Font_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (currentFile == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "RTF File (*.rtf)|*.rtf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    currentFile = sfd.FileName;
                    rtb_vanban.SaveFile(currentFile);
                    MessageBox.Show("Đã lưu!");
                    isSaved = true;
                }
            }
            else
            {
                rtb_vanban.SaveFile(currentFile);
                MessageBox.Show("Đã lưu!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rtb_vanban.Clear();
            cb_Font.Text = "Tahoma";
            cb_Size.Text = "14";
            rtb_vanban.Font = new Font("Tahoma", 14);

            currentFile = "";
            isSaved = false;
        }
    }
}
