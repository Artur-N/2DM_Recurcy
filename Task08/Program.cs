// 8. Дан целочисленный двумерный массив, размерности n х m. Найти среднее арифметическое всех элементов массива.

Random rnd = new Random();
void SetArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}");
        }
        Console.WriteLine();
    }
}

double Task08(int[,] array)
{
    double average;
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
    }
    average = sum/array.Length;
    return average;
}

int[,] array2D = new int[3, 3];
SetArray2D(array2D);
PrintArray(array2D);
Console.WriteLine($"Ср.арифм. массива = {Task08(array2D),0:f}");