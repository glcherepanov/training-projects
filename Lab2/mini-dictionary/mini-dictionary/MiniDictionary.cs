using System.Collections.Generic;
using System.Linq;


namespace mini_dictionary
{
    public class MiniDictionary
    {
        public Dictionary<string, string> _dictionaryWords { get; } = new Dictionary<string, string>();

        public string Search( string word )
        {
            return _dictionaryWords.GetValueOrDefault( ToLowerCase( word ) ) 
                ?? ( _dictionaryWords.Values.Contains( word ) ? _dictionaryWords.FirstOrDefault( w => w.Value == ToLowerCase( word ) ).Key : null );
        }

        public void Add( string word, string translate )
        {
            _dictionaryWords.TryAdd( word, translate );
        }

        private string ToLowerCase( string word )
        {
            return word.ToLower();
        }
    }
}
