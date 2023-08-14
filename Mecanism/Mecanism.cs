using Mecanism.SecurityElements.Interfaces;

namespace Mecanism
{
	internal class Mecanism
	{
        private readonly IEnumerable<ISecurityElement> _algorithms;

        internal Mecanism(IEnumerable<ISecurityElement> algorithms)
		{
            _algorithms = algorithms;
		}

        internal string Encrypt(string text)
        {
            foreach (var algorithm in _algorithms)
            {
                text = algorithm.Encrypt(text);
            }
            return text;
        }

        internal string Decrypt(string text)
        {
            foreach (var algorithm in _algorithms.Reverse())
            {
                text = algorithm.Decrypt(text);
            }
            return text;
        }
    }
}

