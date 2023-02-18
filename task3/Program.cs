// В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void PrintMatrix(double[,] arg)
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
void FillMatrix(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(-9,10);
        }
    }
}
void DeleteMin(double[,] arg)
{
    int strmin = 0;
    int rowmin = 0;
    double minel = arg[0,0];
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if(arg[i,j] < minel)
            {
                strmin = i;
                rowmin = j;
                minel = arg[i,j];
            }
        }
    }
    Console.WriteLine($"Новая матрица:");
    double[,] newarg = new double[arg.GetLength(0) - 1, arg.GetLength(1) - 1];
    for (int i = 0; i < newarg.GetLength(0); i++)
    {
        for (int j = 0; j < newarg.GetLength(1); j++)
        {
            if(i < strmin && j < rowmin)
            {
                newarg[i,j] = arg[i,j];
            }
            if(i >= strmin && j < rowmin)
            {
                newarg[i,j] = arg[i + 1,j];
            }
            if(i < strmin && j >= rowmin)
            {
                newarg[i,j] = arg[i,j + 1];
            }
            if(i >= strmin && j >= rowmin)
            {
                newarg[i,j] = arg[i + 1,j + 1];
            }
            Console.Write($"{newarg[i,j]} ");
        }
        Console.WriteLine();
    }

}
Console.WriteLine("Введите количество строк");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов");
int numberN = int.Parse(Console.ReadLine() ?? "0");

double[,]matrix = new double[numberM, numberN];

Console.WriteLine("Исходная матрица:");
FillMatrix(matrix);
PrintMatrix(matrix);
DeleteMin(matrix);