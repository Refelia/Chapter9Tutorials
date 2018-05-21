using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            //Create an instance of the messageForm class.
            MessageForm myMesssageForm = new MessageForm();

            //Display the form 
            myMesssageForm.ShowDialog();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
