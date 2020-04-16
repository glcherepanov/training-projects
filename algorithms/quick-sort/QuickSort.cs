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

            int pivot = list.First();
            List<int> listWithoutFirst = list.Skip( 1 ).ToList();
            List<int> less = listWithoutFirst.Where( item => item <= pivot ).ToList();
            List<int> greater = listWithoutFirst.Where( item => item > pivot ).ToList();

            return Execute( less ).Concat( new[] { pivot } ).Concat( Execute( greater ) ).ToList();
        }
    }
}
