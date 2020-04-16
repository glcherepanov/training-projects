using System.Collections.Generic;

namespace prime_numbers
{
    public class PrimeNumber
    {
        private static readonly int FirstPrimalNumber = 2;
        private static List<bool> _isPrime = new List<bool>();

        public static HashSet<int> GeneratePrimeNumbersSet( int upperBound )
        {
            IsPrimeListInit( upperBound + 1 );

            for ( int i = FirstPrimalNumber; i * i <= upperBound; i++ )
            {
                if ( _isPrime[ i ] )
                {
                    for ( int noPrime = i * i; noPrime <= upperBound; noPrime += i )
                    {
                        _isPrime[ noPrime ] = false;
                    }
                }
            }

            HashSet<int> primeNumbers = new HashSet<int>();

            for (int i = FirstPrimalNumber; i < upperBound; i++ )
            {
                if ( _isPrime[ i] )
                {
                    primeNumbers.Add( i );
                }
            }

            return primeNumbers;
        }

        private static void IsPrimeListInit( int upperBound )
        {
            for ( int i = 0; i < upperBound; i++ )
            {
                _isPrime.Add( true );
            }
        }
    }
}
