using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSimulator
{
    public partial class Form1 : Form
    {
        //Bank Account field with a $1000 starting balance
        private BankAccount account = new BankAccount(1000);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Display the starting balnce.
            balanceLabel.Text = account.balance.ToString("c");
        }

        private void balanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount; //To hold the amount of withdrawal

            //Convert the amount to a decimal
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                //WIthadraw the amount from the account.
                account.Withdraw(amount);

                //Display the new balance
                balanceLabel.Text = account.balance.ToString("c");

                //Clear the textbox
                withdrawTextBox.Clear();
            }
            else
            {
                //Display error message
                MessageBox.Show("Invalid amount");
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount; //To hold the amount f deposit

            //Convert the amount to a decimal.
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                //Deposit the amount into the account.
                account.Deposit(amount);

                //Display the new balance
                balanceLabel.Text = account.balance.ToString("c");

                //Clear the textBox
                depositTextBox.Clear();
            }
            else
            {
                //Display the error message.
                MessageBox.Show("Invalid amount");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
