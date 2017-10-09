using System;

namespace CalculationService
{
    public static class Calculations
    {
        public static string CalculateYourAge(DateTime Dob)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            return Years.ToString();
        }
    }
}
