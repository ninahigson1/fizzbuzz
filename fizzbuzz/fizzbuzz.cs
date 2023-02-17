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
            if (number % 15 == 0)
            {
                return "fizzbuzz";
            }

            if (number % 5 == 0)
            {
                return "buzz";
            }

            if (number % 3 == 0)
            {
                return "fizz";
            }


            return $"{number}";
        }

        

        

        public string check(int[] input)
        {

            var output = new List<string>();
            for (int i = 0; i < input.Count(); i++)
            {
                check(input[i]);
                output.Add(check(input[i]));
            
            }

            return string.Join(",", output);
        }

        
    }
}
