int nomer = 16; // тізімдегі нөмірім
int n = 5;
int[,] matrix = new int[n, n];
Random rnd = new Random(nomer);
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        matrix[i, j] = rnd.Next(-10, 11);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);

static void PrintMatrix(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            Console.Write($"{m[i, j],4}");
        Console.WriteLine();
    }
}
