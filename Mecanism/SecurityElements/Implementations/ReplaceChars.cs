using Mecanism.SecurityElements.Interfaces;

namespace Mecanism.SecurityElements.Implementations
{
    internal class ReplaceChars : ISecurityElement
    {
        private readonly Func<int, char> _encryptFunc;
        private readonly Func<int, char> _decryptFunc;
        internal ReplaceChars(Func<int, char> encryptFunc, Func<int, char> decryptFunc)
        {
            _encryptFunc = encryptFunc;
            _decryptFunc = decryptFunc;
        }

        public string Decrypt(string text)
        {
            return new (text.Select(x => _decryptFunc(x)).ToArray());
        }

        public string Encrypt(string text)
        {
            return new (text.Select(x => _encryptFunc(x)).ToArray());
        }
    }
}

