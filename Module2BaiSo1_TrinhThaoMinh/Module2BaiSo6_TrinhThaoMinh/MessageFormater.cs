using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo6_TrinhThaoMinh
{
    public partial class MessageFormater : Form
    {
        public MessageFormater()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MessageFormater_KeyDown);

        }

        private void MessageFormater_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + ": " + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
            lblMessage.Text = "";
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    lblMessage.ForeColor = Color.Red;
                   
                    break;
                case "radGreen":
                    lblMessage.ForeColor = Color.Green;
                 
                    break;
                case "radBlue":
                    lblMessage.ForeColor = Color.Blue;
                   
                    break;
                default:
                    lblMessage.ForeColor = Color.Black;
                   
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageFormater_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                lblMessage.Text = txtName.Text + ": " + txtMessage.Text;
            }
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }
    }
    }

