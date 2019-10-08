using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramChecker.Models
{
    public class Dictionary
    {
        public Dictionary()
        {
            DictionaryLines = new List<DictionaryLine>();
        }

        public List<DictionaryLine> DictionaryLines { get; set; }
    }
}
