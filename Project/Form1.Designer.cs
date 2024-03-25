namespace Project
{
    partial class DavidHar_Project_InClass
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblDeposit = new Label();
            txtDepositAmount = new TextBox();
            LblCurrentBalance = new Label();
            txtBalance = new TextBox();
            LstOut = new ListBox();
            btnCalculation = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            LblCustName = new Label();
            txtCustomerName = new TextBox();
            Gbx_Bank_Tax = new GroupBox();
            rdoBankTaxForeign = new RadioButton();
            rdoBankTaxHome = new RadioButton();
            Gbx_Quick_Deposit = new GroupBox();
            rdo_Deposit_300 = new RadioButton();
            rdo_Deposit_200 = new RadioButton();
            rdo_Deposit_100 = new RadioButton();
            rdo_Deposit_80 = new RadioButton();
            rdo_Deposit_40 = new RadioButton();
            rdo_Custom_Deposit = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            Interest_Calculation = new RadioButton();
            Gbx_Bank_Tax.SuspendLayout();
            Gbx_Quick_Deposit.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LblDeposit
            // 
            LblDeposit.AutoSize = true;
            LblDeposit.Location = new Point(50, 83);
            LblDeposit.Name = "LblDeposit";
            LblDeposit.Size = new Size(47, 15);
            LblDeposit.TabIndex = 2;
            LblDeposit.Text = "&Deposit";
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.Location = new Point(153, 82);
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new Size(100, 23);
            txtDepositAmount.TabIndex = 3;
            txtDepositAmount.Enter += txtDepositAmount_Enter;
            txtDepositAmount.Leave += txtDepositAmount_Leave;
            // 
            // LblCurrentBalance
            // 
            LblCurrentBalance.AutoSize = true;
            LblCurrentBalance.Location = new Point(50, 124);
            LblCurrentBalance.Name = "LblCurrentBalance";
            LblCurrentBalance.Size = new Size(91, 15);
            LblCurrentBalance.TabIndex = 4;
            LblCurrentBalance.Text = "Current &Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(153, 116);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(100, 23);
            txtBalance.TabIndex = 5;
            txtBalance.Enter += txtBalance_Enter;
            txtBalance.Leave += txtBalance_Leave;
            // 
            // LstOut
            // 
            LstOut.FormattingEnabled = true;
            LstOut.ItemHeight = 15;
            LstOut.Location = new Point(153, 192);
            LstOut.Name = "LstOut";
            LstOut.Size = new Size(444, 124);
            LstOut.TabIndex = 6;
            LstOut.TabStop = false;
            // 
            // btnCalculation
            // 
            btnCalculation.Location = new Point(160, 360);
            btnCalculation.Name = "btnCalculation";
            btnCalculation.Size = new Size(75, 43);
            btnCalculation.TabIndex = 7;
            btnCalculation.Text = "Balance &Calculation";
            btnCalculation.UseVisualStyleBackColor = true;
            btnCalculation.Click += bttnCalculation_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(305, 360);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 43);
            btnClear.TabIndex = 8;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += bttnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(444, 360);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 43);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += bttnQuit_Click;
            // 
            // LblCustName
            // 
            LblCustName.AutoSize = true;
            LblCustName.Location = new Point(50, 46);
            LblCustName.Name = "LblCustName";
            LblCustName.Size = new Size(94, 15);
            LblCustName.TabIndex = 0;
            LblCustName.Text = "Customer &Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(153, 46);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(100, 23);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // Gbx_Bank_Tax
            // 
            Gbx_Bank_Tax.Controls.Add(rdoBankTaxForeign);
            Gbx_Bank_Tax.Controls.Add(rdoBankTaxHome);
            Gbx_Bank_Tax.Location = new Point(357, 29);
            Gbx_Bank_Tax.Name = "Gbx_Bank_Tax";
            Gbx_Bank_Tax.Size = new Size(436, 40);
            Gbx_Bank_Tax.TabIndex = 10;
            Gbx_Bank_Tax.TabStop = false;
            Gbx_Bank_Tax.Text = "Bank Tax";
            // 
            // rdoBankTaxForeign
            // 
            rdoBankTaxForeign.AutoSize = true;
            rdoBankTaxForeign.Location = new Point(173, 19);
            rdoBankTaxForeign.Name = "rdoBankTaxForeign";
            rdoBankTaxForeign.Size = new Size(134, 19);
            rdoBankTaxForeign.TabIndex = 1;
            rdoBankTaxForeign.TabStop = true;
            rdoBankTaxForeign.Text = "Foreign Bank/ $3 Tax";
            rdoBankTaxForeign.UseVisualStyleBackColor = true;
            rdoBankTaxForeign.CheckedChanged += rdoBankTaxForeign_CheckedChanged;
            // 
            // rdoBankTaxHome
            // 
            rdoBankTaxHome.AutoSize = true;
            rdoBankTaxHome.Location = new Point(3, 19);
            rdoBankTaxHome.Name = "rdoBankTaxHome";
            rdoBankTaxHome.Size = new Size(134, 19);
            rdoBankTaxHome.TabIndex = 0;
            rdoBankTaxHome.TabStop = true;
            rdoBankTaxHome.Text = "Home Bank / No Tax";
            rdoBankTaxHome.UseVisualStyleBackColor = true;
            rdoBankTaxHome.CheckedChanged += rdoBankTaxHome_CheckedChanged;
            // 
            // Gbx_Quick_Deposit
            // 
            Gbx_Quick_Deposit.Controls.Add(rdo_Deposit_300);
            Gbx_Quick_Deposit.Controls.Add(rdo_Deposit_200);
            Gbx_Quick_Deposit.Controls.Add(rdo_Deposit_100);
            Gbx_Quick_Deposit.Controls.Add(rdo_Deposit_80);
            Gbx_Quick_Deposit.Controls.Add(rdo_Deposit_40);
            Gbx_Quick_Deposit.Controls.Add(rdo_Custom_Deposit);
            Gbx_Quick_Deposit.Location = new Point(351, 76);
            Gbx_Quick_Deposit.Name = "Gbx_Quick_Deposit";
            Gbx_Quick_Deposit.Size = new Size(444, 44);
            Gbx_Quick_Deposit.TabIndex = 11;
            Gbx_Quick_Deposit.TabStop = false;
            Gbx_Quick_Deposit.Text = "Quick Deposit ";
            // 
            // rdo_Deposit_300
            // 
            rdo_Deposit_300.AutoSize = true;
            rdo_Deposit_300.Location = new Point(378, 19);
            rdo_Deposit_300.Name = "rdo_Deposit_300";
            rdo_Deposit_300.Size = new Size(49, 19);
            rdo_Deposit_300.TabIndex = 5;
            rdo_Deposit_300.TabStop = true;
            rdo_Deposit_300.Text = "$300";
            rdo_Deposit_300.UseVisualStyleBackColor = true;
            rdo_Deposit_300.CheckedChanged += rdo_Deposit_300_CheckedChanged;
            // 
            // rdo_Deposit_200
            // 
            rdo_Deposit_200.AutoSize = true;
            rdo_Deposit_200.Location = new Point(323, 19);
            rdo_Deposit_200.Name = "rdo_Deposit_200";
            rdo_Deposit_200.Size = new Size(49, 19);
            rdo_Deposit_200.TabIndex = 4;
            rdo_Deposit_200.TabStop = true;
            rdo_Deposit_200.Text = "$200";
            rdo_Deposit_200.UseVisualStyleBackColor = true;
            rdo_Deposit_200.CheckedChanged += rdo_Deposit_200_CheckedChanged;
            // 
            // rdo_Deposit_100
            // 
            rdo_Deposit_100.AutoSize = true;
            rdo_Deposit_100.Location = new Point(268, 19);
            rdo_Deposit_100.Name = "rdo_Deposit_100";
            rdo_Deposit_100.Size = new Size(49, 19);
            rdo_Deposit_100.TabIndex = 3;
            rdo_Deposit_100.TabStop = true;
            rdo_Deposit_100.Text = "$100";
            rdo_Deposit_100.UseVisualStyleBackColor = true;
            rdo_Deposit_100.CheckedChanged += rdo_Deposit_100_CheckedChanged;
            // 
            // rdo_Deposit_80
            // 
            rdo_Deposit_80.AutoSize = true;
            rdo_Deposit_80.Location = new Point(219, 19);
            rdo_Deposit_80.Name = "rdo_Deposit_80";
            rdo_Deposit_80.Size = new Size(43, 19);
            rdo_Deposit_80.TabIndex = 2;
            rdo_Deposit_80.TabStop = true;
            rdo_Deposit_80.Text = "$80";
            rdo_Deposit_80.UseVisualStyleBackColor = true;
            rdo_Deposit_80.CheckedChanged += rdo_Deposit_80_CheckedChanged;
            // 
            // rdo_Deposit_40
            // 
            rdo_Deposit_40.AutoSize = true;
            rdo_Deposit_40.Location = new Point(168, 19);
            rdo_Deposit_40.Name = "rdo_Deposit_40";
            rdo_Deposit_40.Size = new Size(43, 19);
            rdo_Deposit_40.TabIndex = 1;
            rdo_Deposit_40.TabStop = true;
            rdo_Deposit_40.Text = "$40";
            rdo_Deposit_40.UseVisualStyleBackColor = true;
            rdo_Deposit_40.CheckedChanged += rdo_Deposit_40_CheckedChanged;
            // 
            // rdo_Custom_Deposit
            // 
            rdo_Custom_Deposit.AutoSize = true;
            rdo_Custom_Deposit.Location = new Point(16, 19);
            rdo_Custom_Deposit.Name = "rdo_Custom_Deposit";
            rdo_Custom_Deposit.Size = new Size(110, 19);
            rdo_Custom_Deposit.TabIndex = 0;
            rdo_Custom_Deposit.TabStop = true;
            rdo_Custom_Deposit.Text = "Custom Deposit";
            rdo_Custom_Deposit.UseVisualStyleBackColor = true;
            rdo_Custom_Deposit.CheckedChanged += rdo_Custom_Deposit_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(Interest_Calculation);
            groupBox1.Location = new Point(354, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 40);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction Type";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(284, 15);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(76, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Withdraw";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(165, 15);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Deposit";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Interest_Calculation
            // 
            Interest_Calculation.AutoSize = true;
            Interest_Calculation.Location = new Point(13, 15);
            Interest_Calculation.Name = "Interest_Calculation";
            Interest_Calculation.Size = new Size(127, 19);
            Interest_Calculation.TabIndex = 0;
            Interest_Calculation.TabStop = true;
            Interest_Calculation.Text = "Interest Calculation";
            Interest_Calculation.UseVisualStyleBackColor = true;
            Interest_Calculation.CheckedChanged += Interest_Calculation_CheckedChanged;
            // 
            // DavidHar_Project_InClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(Gbx_Quick_Deposit);
            Controls.Add(Gbx_Bank_Tax);
            Controls.Add(txtCustomerName);
            Controls.Add(LblCustName);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculation);
            Controls.Add(LstOut);
            Controls.Add(txtBalance);
            Controls.Add(LblCurrentBalance);
            Controls.Add(txtDepositAmount);
            Controls.Add(LblDeposit);
            Name = "DavidHar_Project_InClass";
            Text = "DavidHar_Project_InClass";
            Load += DavidHar_Project_InClass_Load;
            Gbx_Bank_Tax.ResumeLayout(false);
            Gbx_Bank_Tax.PerformLayout();
            Gbx_Quick_Deposit.ResumeLayout(false);
            Gbx_Quick_Deposit.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblDeposit;
        private TextBox txtDepositAmount;
        private Label LblCurrentBalance;
        private TextBox txtBalance;
        private ListBox LstOut;
        private Button btnCalculation;
        private Button btnClear;
        private Button btnQuit;
        private Label LblCustName;
        private TextBox txtCustomerName;
        private GroupBox Gbx_Bank_Tax;
        private RadioButton rdoBankTaxForeign;
        private RadioButton rdoBankTaxHome;
        private GroupBox Gbx_Quick_Deposit;
        private RadioButton rdo_Custom_Deposit;
        private RadioButton rdo_Deposit_40;
        private RadioButton rdo_Deposit_80;
        private RadioButton rdo_Deposit_100;
        private RadioButton rdo_Deposit_300;
        private RadioButton rdo_Deposit_200;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton Interest_Calculation;
    }
}
