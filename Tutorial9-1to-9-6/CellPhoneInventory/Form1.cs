using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhoneInventory
{
    public partial class Form1 : Form
    {
        //List to hold Cellphone objects
        List<CellPhone> PhoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }
        //The GetPhoneData method accepts a cellphone object as an argument.It assigns the data entered by the user
        //to the objects properties.
        private void GetPhoneData(CellPhone phone)
        {
            //Temporary variable to hold the price.
            decimal price;

            //Get the phone's brand.
            phone.model = modelTextBox.Text;

            //Get the phone's price.
            if(decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.price = price;
            }
            else
            {
                //Display an error message.
                MessageBox.Show("Invalid price");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            //Create a phone object 
            CellPhone myPhone = new CellPhone();

            //Get the phone data.
            GetPhoneData(myPhone);

            //Add the cellphone object to the list.
            PhoneList.Add(myPhone);

            //Add an entry to the list box.
            phoneListBox.Items.Add(myPhone.brand + " " + myPhone.model);

            //Clear the textbox controls.
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            //Reset the focus
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the index of the selected item
            int index = phoneListBox.SelectedIndex;

            //Display the selected item's price.
            MessageBox.Show(PhoneList[index].price.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
                this.Close();
        }
    }
}
