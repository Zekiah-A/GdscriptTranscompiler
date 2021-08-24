using GdscriptTranscompiler.Tokenizing;
using System;

namespace CommandLine
{
    internal class Program
    {
        private static void Main()
        {
            // All of this is temporary.
            while (true)
            {
                var tokens = new Tokenizer(Console.ReadLine()).Run();
                foreach (var item in tokens)
                    Console.WriteLine(item);
            }
        }
    }
}
