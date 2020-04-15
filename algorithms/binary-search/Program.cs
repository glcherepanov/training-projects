using System;
using System.Collections.Generic;

namespace binary_search
{
    class Program
    {
        private static readonly Dictionary<int, int> _dictionary = new Dictionary<int, int>();
        private static readonly int DictionarySize = 500;

        static void Main( string[] args )
        {
            for ( int i = 0; i < DictionarySize; i++ )
            {
                _dictionary.Add( i, i );
            }

            Console.WriteLine( BinarySearch.Execute( _dictionary, 50 ) );
        }
    }
}
