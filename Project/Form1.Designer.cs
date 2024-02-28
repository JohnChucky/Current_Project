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
            // DavidHar_Project_InClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
