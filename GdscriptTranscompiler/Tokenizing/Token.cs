namespace GdscriptTranscompiler.Tokenizing
{
    public class Token
    {
        public TokenType Type { get; }

        public object Value { get; }

        public Token(TokenType type)
        {
            Type = type;
            Value = type.ToString().ToLower();
        }

        public Token(TokenType type, object value)
        {
            Type = type;
            Value = value;
        }
    }
}
