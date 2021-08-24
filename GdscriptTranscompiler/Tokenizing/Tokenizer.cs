using System;
using System.Collections.Generic;

namespace GdscriptTranscompiler.Tokenizing
{
    public class Tokenizer
    {
        private int current;
        private int start;

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

        private bool IsAtEnd()
            => current >= source.Length;

        private char Advance()
            => IsAtEnd() ? '\0' : source[current++];

        private char Peek(int distance = 0)
            => IsAtEnd() ? '\0' : source[current + distance];

        private bool Match(char expected)
        {
            if (Peek() == expected)
            {
                Advance();
                return true;
            }

            return false;
        }
    }
}
