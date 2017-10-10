using ClassLibrary1;
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
    public partial class CalculateMyAge : Form
    {
        public readonly IAgeCalculator _ageCalculator;
        public CalculateMyAge(IAgeCalculator ageCalculator)
        {
            _ageCalculator = ageCalculator;
        }
        public CalculateMyAge()
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
            IAgeCalculator ageCalculator;
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var birthDate = dateTimePicker.Value;
            ageCalculator = new AgeCalculator();
            string age = ageCalculator.CalculateAge(birthDate);
            resault.Text = String.Format("{0} {1}, you are {2} years old", firstName, lastName, age);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
