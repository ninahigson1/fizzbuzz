using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class fizzbuzz 
    {
        public string check(int number)
        {
            if (number % 3 == 0)
            {
                return "fizz";
            }

            if (number % 5 == 0)
            {
                return "buzz";
            }

            return $"{number}";
        }

        
       
    }
}
