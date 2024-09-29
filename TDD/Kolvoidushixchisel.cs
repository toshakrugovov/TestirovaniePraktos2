using System;

namespace TDD
{
    public class Kolvoidushixchisel
    {
        public int kolvoidushixchisel1(string a) 
        {
            int max = 0;
            int current = 0;

            foreach (char c in a)
            {
                if (char.IsDigit(c))
                    max = Math.Max(max, ++current);
                else
                    current = 0;
            }

            return max;
        }
    }
}
