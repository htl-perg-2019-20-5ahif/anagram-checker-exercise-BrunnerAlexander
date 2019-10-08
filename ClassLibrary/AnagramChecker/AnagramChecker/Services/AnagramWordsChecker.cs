using System;
using System.Linq;

namespace AnagramChecker.Services
{
    public class AnagramWordsChecker : IAnagramWordsChecker
    {
        public bool Check(string w1, string w2)
        {
            return String.Concat(w1.OrderBy(l => l)).Equals(String.Concat(w2.OrderBy(l => l)));
        }
    }
}
