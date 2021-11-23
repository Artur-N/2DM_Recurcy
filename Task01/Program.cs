// 1. Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива.

void SetArr2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i * 2 + j + 1;
        }
    }
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}

void Task01(int[,] arr, out int sum, out int multi)
{
    sum = 0;
    multi = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
            multi = multi * arr[i, j];
        }
    }
}
int a = 3;
int b = 3;
int[,] Array = new int[a, b];
SetArr2D(Array);
Print(Array);
int s, m;
Task01(Array, out s, out m);
Console.WriteLine($"Суммы всех элементов массива = {s}");
Console.WriteLine($"Произведение всех элементов массива = {m}");