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

        string result = CollapseSpaces(text, out int removed);

        // Тырнақшалар бос орындардың басы мен соңында қалғанын көрсету үшін
        Console.WriteLine($"Бастапқы жол: [{text}]");
        Console.WriteLine($"Нәтиже:       [{result}]");
        Console.WriteLine($"Алынған бос орындар саны: {removed}");
    }

    // Қатар тұрған бірнеше бос орынды бір бос орынмен алмастырады,
    // removed параметрі алынып тасталған артық бос орындар санын қайтарады
    static string CollapseSpaces(string text, out int removed)
    {
        string result = "";
        bool previousWasSpace = false;
        removed = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == ' ')
            {
                if (!previousWasSpace)
                    result += ch;
                else
                    removed++; // алдыңғы символ да бос орын болды, бұл артық
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