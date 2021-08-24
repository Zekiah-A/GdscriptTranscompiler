using System.Collections.Generic;

namespace GdscriptTranscompiler.Tokenizing
{
    public static class ReservedIdentifiers
    {
        public static readonly IReadOnlyDictionary<string, TokenType> Keywords =
            new Dictionary<string, TokenType>
            {
                { "if", TokenType.If },
                { "elif", TokenType.Elif },
                { "else", TokenType.Else },
                { "for", TokenType.For },
                { "while", TokenType.While },
                { "break", TokenType.Break },
                { "continue", TokenType.Continue },
                { "pass", TokenType.Pass },
                { "return", TokenType.Return },
                { "extends", TokenType.Extends },
                { "is", TokenType.Is },
                { "self", TokenType.Self },
                { "signal", TokenType.Signal },
                { "func", TokenType.Func },
                { "const", TokenType.Const },
                { "var", TokenType.Var },
                { "onready", TokenType.OnReady },
                { "export", TokenType.Export },
                { "preload", TokenType.Preload },
                { "yield", TokenType.Yield },
            };
    }
}
