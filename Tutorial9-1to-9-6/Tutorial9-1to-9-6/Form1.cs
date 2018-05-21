using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial9_1to_9_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //Create a coin object.
            coin myCoin = new coin();

            //Clear the ListBox1
            outputListBox.Items.Clear();

            //Toss the coin five times.
            for (int count = 0; count < 5; count++) ;
            {
                //Toss the coin.
                myCoin.Toss();

                //Display the side the is up 
                outputListBox.Items.Add(myCoin.GetSideUp());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
