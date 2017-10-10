using ClassLibrary1;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMyAgeConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAgeCalculator ageCalculator = new AgeCalculator();
            Application.Start(ageCalculator);
        }       
    }
}
