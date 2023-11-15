using System;


namespace Tymakov_10
{
    internal class BCipher : ICipher
    {
        public string Encode(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    char baseChar = (Char.IsLower(chars[i])) ? 'a' : 'A';
                    chars[i] = (char)(baseChar + ('z' - chars[i]));
                }
            }
            return new string(chars);
        }

        public string Decode(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    char baseChar = (Char.IsLower(chars[i])) ? 'a' : 'A';
                    chars[i] = (char)(baseChar + ('z' - chars[i]));
                }
            }
            return new string(chars);
        }
    }
}
