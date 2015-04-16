using System;

namespace largestPrimeFactor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

			Find the sum of all the primes below two million.
			 * */

			double sum = 0;

			for (long i = 2; i < 2000000; i++) {

				if (isPrime (i) == true) {
					sum += i;
				}

			}

			Console.WriteLine (sum);
				


		}

		public static Boolean isPrime(long n)
		{
			

			if (n == 2) {
				return true;
			}

			if(n % 2 == 0) 
			{
				return false;
			}


			for (int i = 3; i <= Math.Sqrt (n); i++) {
				if (n % i == 0) {
					return false;
				}
					
			}
			return true;	
		}



	
	}
}
