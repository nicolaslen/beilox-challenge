using Mecanism.SecurityElements.Implementations;
using Mecanism.SecurityElements.Interfaces;

namespace Mecanism
{
	public class Library
	{
        private readonly Mecanism _mecanism;
		public Library()
		{
            var algorithms = new List<ISecurityElement>
            {
                new ReplaceChars(x => (char)(x + 1), x => (char)(x - 1)),
                new InvertStringOrder(),
                new LinqAndRecursion()
            };

            _mecanism = new Mecanism(algorithms);
        }

        public string Encrypt(string text)
        {
            Validation.ValidateInput(text);
            return _mecanism.Encrypt(text);
        }

        public string Decrypt(string text)
        {
            return _mecanism.Decrypt(text);
        }
    }
}

