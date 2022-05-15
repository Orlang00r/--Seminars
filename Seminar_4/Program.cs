int SumOfDiagonal(int[,] quad)
{
    int sum = 0;
    for (int i = 0; i < quad.GetLength(0); i++)
    {
        sum += quad[i, i];
    }
    return sum;
}

Console.Write("input size of matrix");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine(SumOfDiagonal(matrix));
