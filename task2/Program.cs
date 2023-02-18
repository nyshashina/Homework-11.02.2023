// Найти произведение двух матриц
void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i,j]} ");
        }
        Console.WriteLine();
    }

}
void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(0,5);
        }
    }
}
void MultiMatrix(int[,] arg1, int[,] arg2)
{
    int[,] arg3 = new int[arg1.GetLength(0), arg2.GetLength(1)];
    for(int i = 0; i < arg3.GetLength(0); i++)
    {
        for (int j =0; j < arg3.GetLength(1); j++)
        {
            for (int k = 0; k < arg1.GetLength(0); k++)
            {
                arg3[i,j] = arg3[i,j] + (arg1[i,k] * arg2[k,j]);
            }
        }
    }
    for (int i = 0; i < arg3.GetLength(0); i++)
    {
        for (int j =0; j < arg3.GetLength(1); j++)
        {
            Console.Write($"{arg3[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк первой матрицы");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов первой матрицы");
int numberN = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов второй матрицы");
int numberO = int.Parse(Console.ReadLine() ?? "0");

int[,]matrixA = new int[numberM, numberN];

int[,]matrixB = new int[numberN, numberO];

Console.WriteLine("Первая матрица:");
FillMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine("Вторая матрица:");
FillMatrix(matrixB);
PrintMatrix(matrixB);
Console.WriteLine("Произведение первой и второй матриц:");
MultiMatrix(matrixA, matrixB);