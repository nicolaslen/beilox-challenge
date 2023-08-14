namespace Mecanism.SecurityElements.Interfaces
{
    internal interface ISecurityElement
    {
        string Encrypt(string text);
        string Decrypt(string text);
    }
}

