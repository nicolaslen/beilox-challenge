namespace Mecanism.SecurityElements.Interfaces
{
    public interface ISecurityElement
    {
        string Encrypt(string text);
        string Decrypt(string text);
    }
}

