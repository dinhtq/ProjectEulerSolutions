using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem20
{
    class Program
    {
        static void Main(string[] args)
        {

            var product = new BigInteger(100);
            int count = 99;

            //get factorial
            while (count > 0)
            {
                //Console.WriteLine(product + " x " + count);
                product *= count;
            
                count--;
            }

            //convert number to string
            String number = product.ToString();

            //convert string to array of char
            char[] nArray = number.ToCharArray();

            long sum = 0;

            //convert each char in array to numbers and add to sum
            for(int i=0; i < nArray.Length; i++) {
                //convert char to double
                double n = Char.GetNumericValue(nArray[i]);
                sum += (long)n;

            }

            //Console.WriteLine(product);
            Console.WriteLine(sum);


        }
    }
}
