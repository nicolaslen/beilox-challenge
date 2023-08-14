using System;
using Mecanism.SecurityElements.Implementations;

namespace Tests
{
    public class InvertStringOrderShould
    {
        [Fact]
        public void ReturnInvertedString()
        {
            var encryption = new InvertStringOrder();
            string input = "Hello world";

            string encrypted = encryption.Encrypt(input);
            string decrypted = encryption.Decrypt(encrypted);

            Assert.Equal("dlrow olleH", encrypted);
            Assert.Equal(input, decrypted);
        }
    }
}

