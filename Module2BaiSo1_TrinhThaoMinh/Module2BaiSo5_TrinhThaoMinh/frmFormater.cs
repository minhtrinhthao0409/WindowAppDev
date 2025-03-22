using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo5_TrinhThaoMinh
{
    public partial class frmFormater : Form
    {
        public frmFormater()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmFormater_KeyDown);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text.Trim();
            txtNhapTen.ForeColor = Color.Black;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void raddo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    lblLapTrinh.ForeColor = Color.Red;
                    txtNhapTen.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lblLapTrinh.ForeColor = Color.Green;
                    txtNhapTen.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    lblLapTrinh.ForeColor = Color.Blue;
                    txtNhapTen.ForeColor = Color.Blue;
                    break;
                default:
                    lblLapTrinh.ForeColor = Color.Black;
                    txtNhapTen.ForeColor = Color.Black;
                    break;
            }
        }


        private void frmFormater_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {

            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^
            FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^
            FontStyle.Italic);
        }

        private void chkUderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^
            FontStyle.Underline);
        }

        private void frmFormater_Load(object sender, EventArgs e)
        {

        }
    }
   }

