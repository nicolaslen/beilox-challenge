// See https://aka.ms/new-console-template for more information

while (true)
{
    int value = 0;
    while (value != 1 && value != 2)
    {
        Console.WriteLine("Ingrese (1) para encriptar, (2) para desencriptar...");
        int.TryParse(Console.ReadLine(), out value);
    }
    string? input = "";
    while (string.IsNullOrEmpty(input))
    {
        Console.WriteLine($"Ingrese el texto a {(value == 1 ? "encriptar" : "desencriptar")}...");
        input = Console.ReadLine();
    }

    var mecanism = new Mecanism.Library();
    string output;
    if (value == 1)
    {
        output = mecanism.Encrypt(input);
    }
    else
    {
        output = mecanism.Decrypt(input);
    }


    Console.WriteLine("Resultado: " + output);
}