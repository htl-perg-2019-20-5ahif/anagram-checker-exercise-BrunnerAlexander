using AnagramChecker.Models;
using AnagramChecker.Services;
using System.Collections;
using System.Collections.Generic;

namespace AnagramChecker.Services
{
    public class DictionaryFileReader
    {

        public DictionaryFileReader()
        {
        }

        public Dictionary Read()
        {
            var text = System.IO.File.ReadAllText(@"dictionary.txt");

            var lines = text.Split("\n");

            Dictionary d = new Dictionary();

            foreach(var line in lines)
            {
                var words = line.Split(",");
                DictionaryLine dl = new DictionaryLine();

                foreach(var word in words)
                {
                    dl.words.Add(word);
                }
                d.DictionaryLines.Add(dl);
            }

            return d;
        }

        public List<string> GetKnown(Dictionary d, string s)
        {
            foreach (DictionaryLine dl in d.DictionaryLines)
            {
                if (dl.words.Contains(s))
                {
                    return dl.words;
                }
            }
            return null;
        }
    }
}
