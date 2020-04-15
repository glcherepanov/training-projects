using System.Collections.Generic;

namespace binary_search
{
    public class BinarySearch
    {
        public static int Execute( Dictionary<int, int> dictionary, int item )
        {
            int low = 0;
            int high = dictionary.Count - 1;

            while ( low <= high )
            {
                int mid = ( low + high ) / 2;
                int guess = dictionary[ mid ];

                if ( guess == item )
                {
                    return mid;
                }
                if ( guess > item )
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}
