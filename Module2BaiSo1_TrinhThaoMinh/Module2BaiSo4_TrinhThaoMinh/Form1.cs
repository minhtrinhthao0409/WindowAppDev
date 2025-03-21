using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo4_TrinhThaoMinh
{
    public partial class frmChangeMoney : Form
    {
        public frmChangeMoney()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtMoney.Text.Trim() == "" || !int.TryParse(txtMoney.Text.Trim(), out _))
            {
                errorProvider1.SetError(txtMoney, "Please enter a valid number.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        
        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            double vnd_usd = (double)1 / 17861;
            double result = Math.Round((double.Parse(txtMoney.Text.Trim()) * vnd_usd), 2);
            lblResult.Text = result.ToString();
        }
        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            double eur_vnd = (double)1 / 27043;
            double result = Math.Round((double.Parse(txtMoney.Text.Trim()) * eur_vnd),2);
            lblResult.Text = result.ToString();
        }

        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            int usd_vnd =  17861;

            lblResult.Text = (int.Parse(txtMoney.Text.Trim()) * usd_vnd).ToString();
            
        }

        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            int vnd_eur =  27043;

            lblResult.Text = (int.Parse(txtMoney.Text.Trim()) * vnd_eur).ToString();

        }
    }
}
