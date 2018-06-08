using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        public bool IsThisPrime(int NumberToTest)
        {
            if (NumberToTest < 2)
            { return false; }
            else

                for (int i = 2; i < NumberToTest; i++)
                {
                    if ((NumberToTest % i) == 0)
                        return false;
                }
            return true;
        }
    }
}
