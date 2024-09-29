using System.Linq;

namespace TDD
{
    public class Korotkoeslovovstroke
    {
        
            public string Korotkoeslovovstrok(string input)
            {
                string[] a = input.Split(' ');
                return a.OrderBy(ab => ab.Length).First();
            }
        
    }
}