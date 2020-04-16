using System;

namespace prime_numbers
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( PrimeNumber.GeneratePrimeNumbersSet( 100000000 ).Count );
        }
    }
}
