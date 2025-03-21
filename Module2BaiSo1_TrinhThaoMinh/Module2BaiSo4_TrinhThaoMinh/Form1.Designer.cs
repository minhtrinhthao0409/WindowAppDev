namespace Module2BaiSo4_TrinhThaoMinh
{
    partial class frmChangeMoney
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblKq = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnVNDtoUSD = new System.Windows.Forms.Button();
            this.btnVNDtoEUR = new System.Windows.Forms.Button();
            this.btnUSDtoVND = new System.Windows.Forms.Button();
            this.btnEURtoVND = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI TIỀN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(34, 81);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(97, 16);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Tiền quy đổi:";
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKq.Location = new System.Drawing.Point(40, 168);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(63, 16);
            this.lblKq.TabIndex = 2;
            this.lblKq.Text = "Kết quả:";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(158, 77);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(321, 20);
            this.txtMoney.TabIndex = 3;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // btnVNDtoUSD
            // 
            this.btnVNDtoUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVNDtoUSD.Location = new System.Drawing.Point(43, 115);
            this.btnVNDtoUSD.Name = "btnVNDtoUSD";
            this.btnVNDtoUSD.Size = new System.Drawing.Size(115, 31);
            this.btnVNDtoUSD.TabIndex = 5;
            this.btnVNDtoUSD.Text = "VND to USD";
            this.btnVNDtoUSD.UseVisualStyleBackColor = true;
            this.btnVNDtoUSD.Click += new System.EventHandler(this.btnVNDtoUSD_Click);
            // 
            // btnVNDtoEUR
            // 
            this.btnVNDtoEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVNDtoEUR.Location = new System.Drawing.Point(164, 115);
            this.btnVNDtoEUR.Name = "btnVNDtoEUR";
            this.btnVNDtoEUR.Size = new System.Drawing.Size(115, 31);
            this.btnVNDtoEUR.TabIndex = 6;
            this.btnVNDtoEUR.Text = "VND to EUR";
            this.btnVNDtoEUR.UseVisualStyleBackColor = true;
            this.btnVNDtoEUR.Click += new System.EventHandler(this.btnVNDtoEUR_Click);
            // 
            // btnUSDtoVND
            // 
            this.btnUSDtoVND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSDtoVND.Location = new System.Drawing.Point(285, 115);
            this.btnUSDtoVND.Name = "btnUSDtoVND";
            this.btnUSDtoVND.Size = new System.Drawing.Size(115, 31);
            this.btnUSDtoVND.TabIndex = 7;
            this.btnUSDtoVND.Text = "USD to VND";
            this.btnUSDtoVND.UseVisualStyleBackColor = true;
            this.btnUSDtoVND.Click += new System.EventHandler(this.btnUSDtoVND_Click);
            // 
            // btnEURtoVND
            // 
            this.btnEURtoVND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEURtoVND.Location = new System.Drawing.Point(406, 115);
            this.btnEURtoVND.Name = "btnEURtoVND";
            this.btnEURtoVND.Size = new System.Drawing.Size(115, 31);
            this.btnEURtoVND.TabIndex = 8;
            this.btnEURtoVND.Text = "EUR to VND";
            this.btnEURtoVND.UseVisualStyleBackColor = true;
            this.btnEURtoVND.Click += new System.EventHandler(this.btnEURtoVND_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(161, 168);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(5);
            this.lblResult.Size = new System.Drawing.Size(318, 25);
            this.lblResult.TabIndex = 9;
            // 
            // frmChangeMoney
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(561, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEURtoVND);
            this.Controls.Add(this.btnUSDtoVND);
            this.Controls.Add(this.btnVNDtoEUR);
            this.Controls.Add(this.btnVNDtoUSD);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmChangeMoney";
            this.Text = "Đổi tiền";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnVNDtoUSD;
        private System.Windows.Forms.Button btnVNDtoEUR;
        private System.Windows.Forms.Button btnUSDtoVND;
        private System.Windows.Forms.Button btnEURtoVND;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblResult;
    }
}

