using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TDD
{
    public class Kolvoslovvstorke
    {
        public int Kolvoslovvstork(string a)
        {
            return a.Split(' ').Length;
        }
    }
}