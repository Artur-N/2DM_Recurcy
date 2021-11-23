// 2. Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение четных элементов.

void SetArr2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random Rnd = new Random();
            arr[i, j] = Rnd.Next(1, 10);
        }
    }
}
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}");
        }
    Console.WriteLine();
    }
}

void Task02(int[,] arr, out int sum, out int multi)
{
    sum = 0;
    multi = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j]%2==0)
            {
                sum = sum + arr[i,j];
                multi = multi*arr[i,j]; 
            }
        }
    }
}
int[,] Array2D = new int[3, 4];
SetArr2D(Array2D);
Print(Array2D);
int s, m;
Task02(Array2D, out s, out m);
Console.WriteLine($"Сумма чётных элементов = {s}");
Console.WriteLine($"Произведение чётных элементов = {m}");