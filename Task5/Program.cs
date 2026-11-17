int nomer = 16; // тізімдегі нөмірім
int n = 5;
int[,] matrix = new int[n, n];
Random rnd = new Random(nomer);
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        matrix[i, j] = rnd.Next(-10, 11);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);

int count = CountEvenNegativeBelowDiagonal(matrix);
Console.WriteLine($"Бас Диагональдан Төмен жұп теріс элементер саны = {count}");
// Бас диагональдан төмен (j < i) жұп теріс санын қайтарады 
// көбейтіндісін product параметрі арқылы береді.
static int CountEvenNegativeBelowDiagonal(int[,] m)
{
    int count = 0;
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0 ; j < i; j++)
        {
            int value = m[i, j];
            if (value < 0 && value % 2 == 0)
            {
                count++;
            }
        }
    }
    return count;
}

static void PrintMatrix(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            Console.Write($"{m[i, j],4}");
        Console.WriteLine();
    }
}
