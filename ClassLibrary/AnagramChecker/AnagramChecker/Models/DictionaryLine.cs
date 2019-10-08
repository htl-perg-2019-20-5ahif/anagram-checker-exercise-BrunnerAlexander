using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramChecker.Models
{
    public class DictionaryLine
    {
        public DictionaryLine()
        {
            words = new List<string>();
        }

        public List<string> words { get; set; }


    }
}
