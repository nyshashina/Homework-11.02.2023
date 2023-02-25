// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {   
            if(arg[i,j] > 0 && arg[i,j] < 10)
            {
                Console.Write($"{arg[i,j]}   ");
            }
            else if(arg[i,j] > 9 && arg[i,j] < 100)
            {
                Console.Write($"{arg[i,j]}  ");
            }
            else if(arg[i,j] > 99 && arg[i,j] < 1000)
            {
                Console.Write($"{arg[i,j]} ");
            }
            else if(arg[i,j] == 0)
            {
                Console.Write($"    ");
            }
        }
        Console.WriteLine();
    }

}
void FillMatrix(int[,] arg)
{   
    arg[0,arg.GetLength(1)/2] = 1;
    for (int i = 1; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if(j == arg.GetLength(1) - 1)
            {
                arg[i,j] = arg[i-1,j-1];
            }
            else if(j == 0)
            {
                arg[i,j] = arg[i-1,j+1];
            }

            else
            {
                arg[i,j] = arg[i-1,j-1] + arg[i-1,j+1];
            }
        }
    }
}

Console.WriteLine("Введите количество строк треугольника Паскаля");
int numberM = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[numberM,numberM*2-1];

FillMatrix(matrix);
PrintMatrix(matrix);