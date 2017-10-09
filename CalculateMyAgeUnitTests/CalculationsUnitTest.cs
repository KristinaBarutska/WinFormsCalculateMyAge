using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace CalculateMyAgeUnitTests
{
    [TestClass]
    public class CalculationsUnitTest
    {
        [TestMethod]
        public void CalculateMyAgeShouldReturnAgeOf18()
        {
            DateTime birthDate = Convert.ToDateTime("1/1/1999");
            DateTime fakeDate= Convert.ToDateTime("9/10/2017");
            Calculations calculations = new Calculations();
            string returnedAge = calculations.CalculateYourAge(birthDate, fakeDate);

            Assert.AreEqual("18", returnedAge);
        }
    }
}
