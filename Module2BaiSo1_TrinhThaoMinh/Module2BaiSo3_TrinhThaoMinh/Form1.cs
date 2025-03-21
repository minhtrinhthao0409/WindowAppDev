using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo3_TrinhThaoMinh
{
    public partial class frmFullName : Form
    {
        public frmFullName()
        {
            InitializeComponent();
            // Enable key preview for the form
            this.KeyPreview = true;
            // Subscribe to KeyDown event
            this.KeyDown += new KeyEventHandler(frmFullName_KeyDown);
        }

        private void frmFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.btnHoTen_Click(sender, e);
            }
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void txtHoLot_TextChanged(object sender, EventArgs e)
        {
            txtHoLot.Text = txtHoLot.Text.Trim();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtTen.Text = txtTen.Text.Trim();
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHoLot.Text + " " + txtTen.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
