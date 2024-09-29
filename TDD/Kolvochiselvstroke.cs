using System.Linq;

namespace TDD
{
    public class Kolvochiselvstroke
    {
        public int Kolvochiselvstrok(string a)
        {
            return a.Count(char.IsDigit);
        }
    }
}