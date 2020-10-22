using System;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
		static bool IsPrime(int number)
		{
			if (number == 2) return true;			

			if (number < 2 || number % 2 == 0) return false;

			for (int i = 3; i < number/2; i++)
			{
				if (number % i == 0) return false;
			}

			return true;
		}

		static void AddPrimeNumbersLessThanOrEqualToFifty()
		{
			int addition = 0;

			for (int i = 1; i <= 50; i++)
			{
				if (IsPrime(i)) addition += i;
			}

			Console.WriteLine("La suma de los números primos menores de 50 es: " + addition);
		}

		static void AddFirstFiftyPrimeNumbers()
		{
			int addition = 0;
			
			for (int i = 1, PrimeNumbersFound = 0; PrimeNumbersFound < 50; i++)
			{
				if (IsPrime(i))
				{
					PrimeNumbersFound++;
					addition += i;
				}
			}

			Console.WriteLine("La suma de los 50 primeros números primos es: " + addition);
		}

		static void Main()
        {
			AddPrimeNumbersLessThanOrEqualToFifty();
			AddFirstFiftyPrimeNumbers();
		}

	}
}
