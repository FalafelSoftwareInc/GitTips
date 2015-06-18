using System;

namespace StringCalcKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (!String.IsNullOrEmpty(numbers))
            {
                return 1;
            }
            return 0;
        }
    }
}
