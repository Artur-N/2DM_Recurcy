// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов

Random rnd = new Random();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}

void MinSumString(int[,] array)
{
    int s = 0;
    int min = 1000;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];

        }
        Console.WriteLine($"В {i + 1} строке сумма элементов = {sum}");
        if (sum < min)
        {
            min = sum;
            s = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов {min} в строке {s+1}");
}

int[,] array2D = new int[4, 8];
FillArray(array2D);
PrintArray(array2D);
System.Console.WriteLine();
MinSumString(array2D);
