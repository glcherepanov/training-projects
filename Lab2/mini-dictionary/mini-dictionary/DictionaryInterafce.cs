using System;
using System.IO;

namespace mini_dictionary
{
    public class DictionaryInterafce
    {
        private MiniDictionary _dictionary = new MiniDictionary();
        private readonly DictionaryDataProvider dataProvider = new DictionaryDataProvider( "input.txt" );
        private bool _unknownWord;
        private string _newWord;
        private bool _isChanged = false;
        private readonly string EndProcessing = "...";
        private readonly string SaveChanges = "y";

        public void DictionaryInit()
        {
            _dictionary = dataProvider.GetData();
        }

        public void Interface()
        {
            string currentLine = Console.ReadLine();

            while ( currentLine != EndProcessing )
            {
                if ( _unknownWord )
                {
                    SaveNewTranslate( currentLine );
                }
                else
                {
                    TranslateWord( currentLine );
                }
                currentLine = Console.ReadLine();
            }

            if ( _isChanged )
            {
                Console.WriteLine( "В словарь были внесены изменения. Введите Y или y для сохранения перед выходом." );
                currentLine = Console.ReadLine();
                if ( currentLine.ToLower() == SaveChanges )
                {
                    SaveDictionaryChanges();
                }
                else
                {
                    Console.WriteLine( "До свидания." );
                }
            }
        }

        private void TranslateWord( string word )
        {
            string translatedWord = _dictionary.Search( word );

            if ( translatedWord != null )
            {
                Console.WriteLine( translatedWord );
            }
            else
            {
                Console.WriteLine( @"Неизвестное слово “{0}”. Введите перевод или пустую строку для отказа.", word );
                _newWord = word;
                _unknownWord = true;
            }
        }

        private void SaveNewTranslate( string word )
        {

            if ( word != string.Empty )
            {
                _dictionary.Add( _newWord, word );
                _isChanged = true;
                Console.WriteLine( @"Слово “{0}” сохранено в словаре как “{1}”.", _newWord, word );
            }
            else
            {
                Console.WriteLine( @"Слово “{0}” проигнорировано.", _newWord );
            }

            _unknownWord = false;
        }

        private void SaveDictionaryChanges()
        {
            dataProvider.WriteData( _dictionary );

            Console.WriteLine( @"Изменения сохранены. До свидания." );
        }
    }
}
