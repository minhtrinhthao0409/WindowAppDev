using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Module2BaiSo8_TrinhThaoMinh
{
    public partial class frmGPTB1 : Form
    {
        public frmGPTB1()
        {
            InitializeComponent();
        }

        private void frmGPTB1_Load(object sender, EventArgs e)
        {
            btnCal.Enabled = false;
            btnDel.Enabled = false;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtA.Text, out decimal val1))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập một số hợp lệ");

            }
            else
            {
                errorProvider1.SetError(txtA, ""); // Xóa thông báo lỗi

            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtB.Text, out decimal val2))
            {
                errorProvider2.SetError(txtB, "Vui lòng nhập một số hợp lệ");
            }
            else
            {
                errorProvider2.SetError(txtB, ""); // Xóa thông báo lỗi

            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

        }

        private void btnCal_EnabledChanged(object sender, EventArgs e)
        {
            btnCal.Enabled = decimal.TryParse(txtA.Text, out decimal val1) &&
                    decimal.TryParse(txtB.Text, out decimal val2);
        }
    }
}
