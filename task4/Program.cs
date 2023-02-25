// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
void PrintMatrix(int[,,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            for (int k =0; k < arg.GetLength(2); k++)
            {
                Console.Write($"({i},{j},{k}){arg[i,j,k]}  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
void FillMatrix(int[,,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            for (int k =0; k < arg.GetLength(2); k++)
            {
                int temp = new Random().Next(10,100);
              
                while (ArrayContains(arg, temp))
                {
                    temp = new Random().Next(10, 100);
                }
 
                arg[i,j,k] = temp;
            }
        }
    }
}
bool ArrayContains(int[,,] arg, int temp)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            for (int k = 0; k < arg.GetLength(2); k++)
            {
                if (arg[i,j,k] == temp)
                {
                    return true;
                }
            }
        }
    }
 
    return false;
}

Console.WriteLine("Введите количество страниц трехмерной матрицы");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество строк трехмерной матрицы");
int numberN = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов трехмерной матрицы");
int numberO = int.Parse(Console.ReadLine() ?? "0");

if(numberM * numberN * numberO <= 90)
{
    int [,,] matrix = new int[numberM,numberN,numberO];

    FillMatrix(matrix);
    PrintMatrix(matrix);
}
else
{
    Console.WriteLine("Параметры не допустимы.");
}