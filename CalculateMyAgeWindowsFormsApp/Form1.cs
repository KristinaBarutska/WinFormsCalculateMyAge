using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateMyAgeWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var lastName = lastNameTextBox.Text;
        }

       

        private void submitButton_Click(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var birthDate = dateTimePicker.Value;
            Calculations calculations = new Calculations();
            string age = calculations.CalculateYourAge(birthDate);
            resault.Text = String.Format("{0} {1}, you are {2} years old", firstName, lastName, age);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
