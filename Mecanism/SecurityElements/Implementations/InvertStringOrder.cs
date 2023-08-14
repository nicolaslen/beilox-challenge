using Mecanism.SecurityElements.Interfaces;

namespace Mecanism.SecurityElements.Implementations
{
    internal class InvertStringOrder : ISecurityElement
    {
        public string Decrypt(string text)
        {
            return Reverse(text);
        }

        public string Encrypt(string text)
        {
            return Reverse(text);
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

