using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string text;
        do
        {
            Console.Write("Жолды енгізіңіз: ");
            text = Console.ReadLine();
            if (string.IsNullOrEmpty(text))
                Console.WriteLine("Жол бос. Қайта енгізіңіз.");
        } while (string.IsNullOrEmpty(text));

        string result = CollapseSpaces(text);

        // Тырнақшалар бос орындардың басы мен соңында қалғанын көрсету үшін
        Console.WriteLine($"Бастапқы жол: [{text}]");
        Console.WriteLine($"Нәтиже:       [{result}]");
    }

    // Қатар тұрған бірнеше бос орынды бір бос орынмен алмастырады
    static string CollapseSpaces(string text)
    {
        string result = "";
        bool previousWasSpace = false;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == ' ')
            {
                if (!previousWasSpace)
                    result += ch;
                previousWasSpace = true;
            }
            else
            {
                result += ch;
                previousWasSpace = false;
            }
        }

        return result;
    }
}
