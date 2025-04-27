class Program
{
    static void Main()
    {
        string result = "";

        Console.Write("Texto plano: ");
        var plainText = Console.ReadLine().Trim();
        if (string.IsNullOrEmpty(plainText))
        {
            Console.WriteLine("Digite o texto!");
            return;
        }

        Console.Write("Saltos (ex: 1): ");
        var saltos = int.Parse(Console.ReadLine().Trim());
        if (saltos <= 0)
        {
            Console.WriteLine("Digite a quantidade de saltos!");
            return;
        }

        foreach (char c in plainText)
        {
            char newChar = c;

            if (char.IsLetter(c))
            {
                if (c >= 'a' && c <= 'z')
                {
                    newChar = (char)('a' + (c - 'a' + saltos) % 26);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    newChar = (char)('A' + (c - 'A' + saltos) % 26);
                }
            }
            else
            {
                newChar = c;
            }

            result += newChar;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(result);
        Console.ResetColor();
    }
}