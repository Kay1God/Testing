using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPractical
{
    class StatisticalFunctions
    {
        int[] numbers;

        public void RndmNumbers(int iIn)
        {
            Random rndm = new Random();
            numbers = new int[iIn];

            for (int i = 0; i < iIn; i++)
            {
                numbers[i] = rndm.Next(0, 100);
            }
        }
       public int[] getNumbers()
        {
            return numbers;
        }
        
        public int Product()
        {
            int product = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                product = product * numbers[i];
            }

            return product;
        }
    }
}
