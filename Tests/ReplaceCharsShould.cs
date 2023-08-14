using Mecanism.SecurityElements.Implementations;

namespace Tests
{
    public class ReplaceCharsShould
    {
        [Fact]
        public void ReturnReplacedChars()
        {
            var encryption = new ReplaceChars(x => (char)(x + 1), x => (char)(x - 1));
            string input = "Hello world";

            string encrypted = encryption.Encrypt(input);
            string decrypted = encryption.Decrypt(encrypted);

            Assert.Equal("Ifmmp!xpsme", encrypted);
            Assert.Equal(input, decrypted);
        }
    }
}

