using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays.src
{
    public static class Arrays
    {
        public static IEnumerable<int> GetOddIntegers()
        {
            //BEGIN_CHALLENGE
            // Return an IEnumerable containing all odd numbers in Defaults.Integers
            return Defaults.Integers.Where(x => (x & 1) == 1);
            //END_CHALLENGE
        }

        public static IEnumerable<int> GetFizzBuzz()
        {
            //BEGIN_CHALLENGE
            // Return an IENumerable containing all number divisable by 3 or 5 in Defaults.Integers
            return Defaults.Integers.Where(x => x % 3 == 0 || x % 5 == 0);
            //END_CHALLENGE
        }

        public static IEnumerable<int> Get100to200()
        {
            //BEGIN_CHALLENGE
            // Return an IENumerable containing the numbers 100 to 200 in Defaults.Integers
            return Defaults.Integers.Skip(99).Take(101);
            //END_CHALLENGE
        }

        public static object Get2D()
        {
            //BEGIN_CHALLENGE
            // Return a empty 2 dimensional array of 10 by 10
            return new int[10, 10];
            //END_CHALLENGE
        }
    }
}
