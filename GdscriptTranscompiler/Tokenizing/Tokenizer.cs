using System;
using System.Collections.Generic;

namespace GdscriptTranscompiler.Tokenizing
{
    public class Tokenizer
    {
        private readonly string source;

        /// <param name="source">The old GDScript source-code.</param>
        public Tokenizer(string source)
        {
            this.source = source;
        }

        /// <summary>
        /// Converts old GDScript to a series of tokens.
        /// </summary>
        /// <returns>A read-only span of <see cref="Token"/>.</returns>
        public ReadOnlySpan<Token> Run()
        {
            var tokens = new List<Token>();

            return tokens.ToArray();
        }
    }
}
