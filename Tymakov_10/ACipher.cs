using System;


namespace Tymakov_10
{
    internal class ACipher : ICipher
    {
        public string Encode(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] + 1);
            }
            return new string(chars);
        }

        public string Decode(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] - 1);
            }
            return new string(chars);
        }
    }
}
