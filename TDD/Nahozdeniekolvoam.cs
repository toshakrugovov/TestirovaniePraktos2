namespace TDD
{
    public class Nahozdeniekolvoam
    {
        public int Nahozdeniekolvoam1(string a)
        {
            int count = 0; 

            
            for (int i = 0; i < a.Length - 1; i++)
            {
                
                if (a[i] == 'а' && a[i + 1] == 'м')
                {
                    count++;
                }
            }

            return count; 
        }

    }
}