using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services

{
    public class AgeCalculator: IAgeCalculator
    {
        public string CalculateAge(DateTime birthdate, DateTime? date= null)
        {
            DateTime today;
            if (date == null)
            {
                today = DateTime.Today;
            }
            else today = Convert.ToDateTime(date);

            TimeSpan ts = today - birthdate;
            int age = ts.GetYears();

            return age.ToString();
        }
    }
}
