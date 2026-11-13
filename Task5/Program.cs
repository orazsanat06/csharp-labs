int nomer = 16; // тізімдегі нөмірім
int n = 5;
int[,] matrix = new int[n, n];
Random rnd = new Random(nomer);
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        matrix[i, j] = rnd.Next(-10, 11);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);

int count = CountEvenPositiveAboveDiagonal(matrix, out long product);
if (count == 0)
{
    Console.WriteLine("Бас диагональдан жоғары жұп оң элементтер жоқ.");
}
else
{
    Console.WriteLine($"Бас диагональдан жоғары жұп оң элементтер саны = {count}");
    Console.WriteLine($"Бас диагональдан жоғары жұп оң элементтердің көбейтіндісі = {product}");
}

// Бас диагональдан жоғары (j > i) жұп оң элементтердің санын қайтарады,
// көбейтіндісін product параметрі арқылы береді.
static int CountEvenPositiveAboveDiagonal(int[,] m, out long product)
{
    int count = 0;
    product = 1;
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = i + 1; j < m.GetLength(1); j++)
        {
            int value = m[i, j];
            if (value > 0 && value % 2 == 0)
            {
                count++;
                product *= value;
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
