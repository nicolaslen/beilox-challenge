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
            ValidateInput(text);
            return _mecanism.Encrypt(text);
        }

        public string Decrypt(string text)
        {
            return _mecanism.Decrypt(text);
        }

        private void ValidateInput(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Any(x => !char.IsUpper(x) && !char.IsLower(x) && !char.IsNumber(x)))
            {
                throw new Exception("El conjunto de caracteres de entrada deberá contener únicamente letras (mayúsculas o minúsculas y números)");
            }
        }
    }
}

