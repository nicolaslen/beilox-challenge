using System;
namespace Mecanism
{
	internal static class Validation
	{
        internal static void ValidateInput(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Any(x => !char.IsUpper(x) && !char.IsLower(x) && !char.IsNumber(x)))
            {
                throw new Exception("El conjunto de caracteres de entrada deberá contener únicamente letras (mayúsculas o minúsculas y números)");
            }
        }
    }
}

