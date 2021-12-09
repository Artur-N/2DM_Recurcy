// 55 Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Random rnd = new Random();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],6}");
        }
        Console.WriteLine();
    }
}

void AverageColumn(int[,] array, int s)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == s)
            {
                sum += array[i, j];
            }
        }
    }
    Console.Write($"{sum/array.GetLength(1),6:f1}");
}

int[,] array2D = new int[5, 5];
int s = 0;
FillArray(array2D);
PrintArray(array2D);
System.Console.WriteLine("Среднее арифметическое столбца:");
while (s < array2D.GetLength(1))
{
    AverageColumn(array2D, s);
    s++;
}