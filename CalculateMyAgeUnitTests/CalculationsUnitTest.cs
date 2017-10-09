using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace CalculateMyAgeUnitTests
{
    [TestClass]
    public class AgeCalculatorUnitTest
    {
        [TestMethod]
        public void CalculateMyAgeShouldReturnAgeOf18()
        {
            DateTime birthDate = Convert.ToDateTime("1/1/1999");
            DateTime fakeDate= Convert.ToDateTime("9/10/2017");
            AgeCalculator ageCalculator = new AgeCalculator();
            string returnedAge = ageCalculator.CalculateAge(birthDate, fakeDate);

            Assert.AreEqual("18", returnedAge);
        }
    }
}
