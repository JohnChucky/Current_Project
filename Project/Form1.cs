namespace Project
{
    public partial class DavidHar_Project_InClass : Form
    {
        public DavidHar_Project_InClass()
        {
            InitializeComponent();
        }

        private void bttnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
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

            //input 
            CustomerName = txtCustomerName.Text;
            Deposit = double.Parse(txtDepositAmount.Text);
            Current_Balance = double.Parse(txtBalance.Text);

            //possible processing may change 
            New_Balance = Deposit + Current_Balance;

            //output
            LstOut.Items.Add("Your name is " + CustomerName);
            LstOut.Items.Add("Your current balance was " + Current_Balance.ToString("C")); 
            LstOut.Items.Add("You have just put in " + Deposit.ToString("C"));
            LstOut.Items.Add("The new balance of your account is now " + New_Balance.ToString("C"));






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
    }
}
