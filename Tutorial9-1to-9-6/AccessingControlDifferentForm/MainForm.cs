using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessingControlDifferentForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create an instance of the nutritionalFormClass.
            NutritionalForm nutriForm = new NutritionalForm();

            //Find the selected radio button.
            if(radioButton1.Checked)
            {
                nutriForm.foodOutLabel.Text = "1 banana";
                nutriForm.calOutLabel.Text = "100";
                nutriForm.fatGramsOUtLabel.Text = "0.4";
                nutriForm.gramsOutLabel.Text = "27";
            }
            else
            if(radioButton2.Checked)
            {
                nutriForm.foodOutLabel.Text = "1 cup air-popped popcorn";
                nutriForm.calOutLabel.Text = "31";
                nutriForm.fatGramsOUtLabel.Text = "0.4";
                nutriForm.gramsOutLabel.Text = "6";

            }
            else
            if(radioButton3.Checked)
            {
                nutriForm.foodOutLabel.Text = "1 large blueberry muffin";
                nutriForm.calOutLabel.Text = "385";
                nutriForm.fatGramsOUtLabel.Text = "9";
                nutriForm.gramsOutLabel.Text = "67";
            }

            //Display the nutritionalForm.
            nutriForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
