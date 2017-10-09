using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services

{
    public class Calculations
    {
        public string CalculateYourAge(DateTime birthdate, DateTime? date= null)
        {
            DateTime today;
            if (date == null)
            {
                today = DateTime.Today;
            }
            else today = Convert.ToDateTime(date);

            // Calculate the age.
            var age = today.Year - birthdate.Year;
            // Go back to the year the person was born in case of a leap year
            if (birthdate > today.AddYears(-age)) age--;

            return age.ToString();
        }
    }
}
