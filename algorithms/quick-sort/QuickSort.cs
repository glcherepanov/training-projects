using System.Collections.Generic;
using System.Linq;

namespace quick_sort
{
    public class QuickSort
    {
        public static List<int> Execute( List<int> list )
        {
            if ( list.Count < 2 )
            {
                return list;
            }
            else
            {
                int pivot = list.First();
                List<int> less = list.Skip( 1 ).Where( item => item <= pivot ).ToList();
                List<int> greater = list.Skip( 1 ).Where( item => item > pivot ).ToList();

                return Execute( less ).Concat( new[] { pivot } ).Concat( Execute( greater ) ).ToList();
            }
        }
    }
}
