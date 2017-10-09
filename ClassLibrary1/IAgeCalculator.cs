using System;

namespace ClassLibrary1
{
    public interface IAgeCalculator
    {
        string CalculateAge(DateTime birthdate, DateTime? date = null);
    }
}
