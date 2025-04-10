using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan3_TrinhThaoMinh
{
    public partial class Form1 : Form
    {

        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            
            if ((txtResult.Text == "0") || (isOperationPerformed = true))
            {
                txtResult.Clear();
            }
            isOperationPerformed = false;

            Button button = (Button)sender;

            txtResult.Text = txtResult.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            operationPerformed = button.Text;
            resultValue = Convert.ToDouble(txtResult.Text);
            isOperationPerformed = true;

        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtResult.Text = (resultValue + Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (resultValue - Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (resultValue * Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (resultValue / Convert.ToDouble(txtResult.Text)).ToString();
                    break;

            }
        }
    }
}
