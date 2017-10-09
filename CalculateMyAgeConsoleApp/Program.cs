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
            string firstName;
            string lastName;
            DateTime birthDate;          
            string age;
            bool invalid = true;
            Console.WriteLine("Please enter your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            lastName = Console.ReadLine();

            do
            {
                
                Console.WriteLine("Please enter a date of birth in format (dd/mm/yyyy)");
                string date = Console.ReadLine();
                try
                {
                    birthDate = Convert.ToDateTime(date);
                    Calculations calculations = new Calculations();
                    age = calculations.CalculateYourAge(birthDate);
                    Console.WriteLine(String.Format("{0} {1}, you are {2} years old", firstName, lastName, age));
                    invalid = false;
                    break;
                }

                catch (Exception)
                {
                    Console.WriteLine("Please enter a date of birth in format (dd/mm/yyyy)");
                    date = Console.ReadLine();
                    invalid = true;
                }
               
            }
            while (invalid);

        }       

    }
}
