using Mecanism.SecurityElements.Interfaces;

namespace Mecanism.SecurityElements.Implementations
{
    public class LinqAndRecursion : ISecurityElement
    {
        private readonly int times = 3;

        public string Decrypt(string text)
        {
            return Decrypt(text, times);
        }

        public string Encrypt(string text)
        {
            return Encrypt(text, times);
        }

        private string Encrypt(string text, int times)
        {
            if (times == 0)
                return text;

            return Encrypt(
                new (text.Select(x => char.IsUpper(x) ? char.ToLower(x) : (char.IsLower(x) ? char.ToUpper(x) : (char)(Char.GetNumericValue(x) + 1))).ToArray()),
                times - 1); 
        }

        private string Decrypt(string text, int times)
        {
            if (times == 0)
                return text;

            return Encrypt(
                new(text.Select(x => char.IsUpper(x) ? char.ToLower(x) : (char.IsLower(x) ? char.ToUpper(x) : (char)(Char.GetNumericValue(x) - 1))).ToArray()),
                times - 1);
        }
    }
}

