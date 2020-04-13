using System;

namespace mini_dictionary
{
    class Program
    {
        static void Main( string[] args )
        {
            DictionaryInterafce interafce = new DictionaryInterafce();
            interafce.DictionaryInit();
            interafce.Interface();
        }
    }
}
