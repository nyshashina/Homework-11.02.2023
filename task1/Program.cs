// Составить частотный словарь элементов двумерного массива
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
            arg[i,j] = new Random().Next(0,10);
        }
    }
}
void ArrToArrSort(int[,] arg)
{
    int[] newarr = new int [arg.GetLength(0) * arg.GetLength(1)];
    int count = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            newarr[count] = arg[i,j];
            count++;
        }
    }
    for (int i = 0; i < newarr.Length; i++)
    {
        int temp = 0;
        for (int j = i + 1; j < newarr.Length; j++)
        {
            if(newarr[j] < newarr[i])
            {
                temp = newarr[i];
                newarr[i] = newarr[j];
                newarr[j] = temp;
            }
        }
    }
    foreach(int el in newarr)
    {
        Console.Write(el);
    }
    Console.WriteLine("");
    int temp2 = 1;
    for (int i = 0; i < newarr.Length; i++)
    {
        temp2 = 1;
        for (int j = i + 1; j < newarr.Length; j++)
        {
            if(newarr[j] == newarr[i])
            {
                i++;
                temp2++;
            }
        }
        if(temp2 == 1 || temp2 > 4){
            Console.WriteLine("Символ " + newarr[i] + " встречается "+ temp2 + " раз.");
        }
        if(temp2 > 1 && temp2 < 5){
            Console.WriteLine("Символ " + newarr[i] + " встречается "+ temp2 + " раза.");
        }
    }    

}
Console.WriteLine("Введите количество строк");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов");
int numberN = int.Parse(Console.ReadLine() ?? "0");

int[,]matrix = new int[numberM, numberN];

FillMatrix(matrix);
PrintMatrix(matrix);
ArrToArrSort(matrix);