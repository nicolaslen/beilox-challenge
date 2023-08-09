using System;
using Mecanism.SecurityElements.Interfaces;

namespace Mecanism
{
	public class Mecanism
	{
        private readonly IEnumerable<ISecurityElement> _algorithms;

        public Mecanism(IEnumerable<ISecurityElement> algorithms)
		{
            _algorithms = algorithms;
		}

        public string Encrypt(string text)
        {
            foreach (var algorithm in _algorithms)
            {
                text = algorithm.Encrypt(text);
            }
            return text;
        }

        public string Decrypt(string text)
        {
            foreach (var algorithm in _algorithms.Reverse())
            {
                text = algorithm.Decrypt(text);
            }
            return text;
        }
    }
}

