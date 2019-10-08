using System;
using AnagramChecker.Models;
using AnagramChecker.Services;

namespace AnagramCheckerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 3 && args.Length != 2)
            {
                Console.WriteLine("Please enter check or getKnown followed by the parameters");
                return;
            }

            var awc = new AnagramWordsChecker();
            var dfr = new DictionaryFileReader();

            switch (args[0])
            {
                case "check":
                    if(awc.Check(args[1], args[2]))
                    {
                        Console.WriteLine("\"" + args[1] + "\" and " + "\"" + args[2] + "\" are anagrams");
                    }
                    else
                    {
                        Console.WriteLine("\"" + args[1] + "\" and " + "\"" + args[2] + "\" are no anagrams");
                    }
                    break;

                case "getKnown":
                    Dictionary d = dfr.Read();
                    var result = dfr.GetKnown(d, args[1]);
                    foreach(var s in result)
                    {
                        Console.WriteLine(s);
                    }
                    break;

                default:
                    Console.WriteLine("Please enter a type (check or getKnown) and two strings!");
                    break;
            }
        }
    }
}
