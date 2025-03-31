using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan2_TrinhThaoMinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                var path = dialog.SelectedPath;
                string[] files = Directory.GetFiles(path);
                foreach ( string file in files )
                {
                    if (file.EndsWith(".jpg") || file.EndsWith(".png"))
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Cursor = Cursors.Hand;
                        pictureBox.Load(file);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Tag = file;

                        pictureBox.Click += PictureBox_Click;

                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string imgPath = pictureBox.Tag.ToString();
                pictureBox1.Load(imgPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label1.Text = "File" + imgPath + " is loaded.";
            }
        }
    }
}
