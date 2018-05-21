using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellphoneTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //The GetPhoneData method accepts a cellphone object as an argument. It assigns the data
        //entered by the user to the objects property.
        private void GetPhoneData(CellPhone phone)
        {
            //Temporary variable to hold the price.
            decimal price;

            //Get the phone's model.
            phone.model = modelTextBox.Text;

            //Get the phone's brand.
            phone.brand = brandTextBox.Text;

            //Get the phone's price.
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.price = price;
            }
            else
            {
                //Display error message.
                MessageBox.Show("Invalid price");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //Create a cellphone object.
            CellPhone myPhone = new CellPhone();

            //Get the phone data
            GetPhoneData(myPhone);

            //Display the phone data.
            brandLabel.Text = myPhone.brand;
            modelLabel.Text = myPhone.model;
            priceLabel.Text = myPhone.price.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
