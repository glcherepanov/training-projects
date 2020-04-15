﻿using System;
using System.Collections.Generic;

namespace quick_sort
{
    class Program
    {
        static void Main( string[] args )
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            for ( int i = 0; i < 5; i++ )
            {
                list.Add( rand.Next( 0, 1000 ) );
            }

            list = QuickSort.Execute( list );
            list.ForEach( item => Console.WriteLine( item ) );
        }
    }
}
