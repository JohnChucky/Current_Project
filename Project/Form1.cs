using System.Diagnostics.Eventing.Reader;

namespace Project
{
    public partial class DavidHar_Project_InClass : Form
    {
        public DavidHar_Project_InClass()
        {
            InitializeComponent();
        }

        string InerestCalculation;
        string RdoDeposit;
        string RdoWithdraw;
        double BankTax;
        double Deposit_Amount;
        //For the buttons make it so that they are Interest, Deposit and withdraw buttons.

        private void bttnQuit_Click(object sender, EventArgs e)
        {
            //ICA4
            DialogResult SelectedButton;
            SelectedButton = MessageBox.Show("Do you want to exit?",
                "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (SelectedButton == DialogResult.Yes)
            {
                //Quits the program
                this.Close();
            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            LstOut.Items.Clear();
            txtDepositAmount.Clear();
            txtBalance.Clear();
            //focus
        }

        private void bttnCalculation_Click(object sender, EventArgs e)
        {
            //ICA 3- part 1
            string CustomerName;
            double Deposit;
            double Current_Balance;
            double New_Balance;
            //ICA 4
            bool NDeposit;
            bool CBalance;

            //input 
            CustomerName = txtCustomerName.Text;
            //Deposit = double.Parse(txtDepositAmount.Text);
            NDeposit = double.TryParse(txtDepositAmount.Text, out Deposit);
            //Current_Balance = double.Parse(txtBalance.Text);
            CBalance = double.TryParse(txtBalance.Text, out Current_Balance);
            //ICA 5 Simple Version 
            //Use switch to calculate new balance based on transaction type
            if (NDeposit && CBalance)
            {
                //switch(Inerest)Give it a value

                //possible processing may change 
                New_Balance = Deposit + Current_Balance - BankTax;

                //output
                LstOut.Items.Add("Your name is " + CustomerName);
                LstOut.Items.Add("Your current balance was " + Current_Balance.ToString("C"));
                LstOut.Items.Add("You have just put in " + Deposit.ToString("C"));
                LstOut.Items.Add("The new balance of your account is now " + New_Balance.ToString("C"));

            }
            else
            {
                LstOut.Items.Add("The price input is wrong");
            }
        }

        // non default event procedure
        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.GreenYellow;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
            //
            //or could use system colors


        }

        private void txtDepositAmount_Enter(object sender, EventArgs e)
        {
            txtDepositAmount.BackColor = Color.GreenYellow;
        }

        private void txtDepositAmount_Leave(object sender, EventArgs e)
        {
            txtDepositAmount.BackColor = SystemColors.Window;
        }

        private void txtBalance_Enter(object sender, EventArgs e)
        {
            txtBalance.BackColor = Color.GreenYellow;
        }

        private void txtBalance_Leave(object sender, EventArgs e)
        {
            txtBalance.BackColor = SystemColors.Window;
        }

        private void DavidHar_Project_InClass_Load(object sender, EventArgs e)
        {
            rdoBankTaxHome.Checked = true;
            rdo_Custom_Deposit.Checked = true;
        }

        private void rdoBankTaxHome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBankTaxHome.Checked)
            {
                BankTax = 0;
            }
        }

        private void rdoBankTaxForeign_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBankTaxForeign.Checked)
            {
                BankTax = 3;
            }
        }

        private void rdo_Custom_Deposit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Custom_Deposit.Checked)
            {
                Deposit_Amount = 0;
            }
        }

        private void rdo_Deposit_40_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Deposit_40.Checked)
            {
                Deposit_Amount = 40;
            }
        }

        private void rdo_Deposit_80_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Deposit_80.Checked)
            {
                Deposit_Amount = 80;
            }
        }

        private void rdo_Deposit_100_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Deposit_100.Checked)
            {
                Deposit_Amount = 100;
            }
        }

        private void rdo_Deposit_200_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Deposit_200.Checked)
            {
                Deposit_Amount = 200;
            }
        }

        private void rdo_Deposit_300_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Deposit_300.Checked)
            {
                Deposit_Amount = 300;
            }
        }
    }
}
