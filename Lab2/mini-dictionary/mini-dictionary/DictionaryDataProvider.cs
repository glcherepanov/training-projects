using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mini_dictionary
{
    public class DictionaryDataProvider
    {
        private readonly string _path;
        private readonly int WordIndex = 0;
        private readonly int TranslateIndex = 1;

        public DictionaryDataProvider( string path )
        {
            _path = path;
        }

        public MiniDictionary GetData()
        {
            MiniDictionary dictionary = new MiniDictionary();

            if ( File.Exists( _path ) )
            {
                using ( StreamReader sr = File.OpenText( _path ) )
                {
                    while ( !sr.EndOfStream )
                    {
                        string[] words = sr.ReadLine().Split( '-' );
                        dictionary.Add( words[ WordIndex ], words[ TranslateIndex ] );
                    }
                }
            }

            return dictionary;
        }

        public void WriteData( MiniDictionary dictionary )
        {
            using ( StreamWriter sr = new StreamWriter( File.OpenWrite( _path ) ) )
            {
                foreach ( KeyValuePair<string, string> word in dictionary._dictionaryWords )
                {
                    sr.WriteLine( @"{0}-{1}", word.Key, word.Value );
                }
            }
        }
    }
}
