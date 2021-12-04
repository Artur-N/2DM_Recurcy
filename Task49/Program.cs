// 49. Показать двумерный массив размером m×n заполненный вещественными числами

Random rnd = new Random();
void FillArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble()*10;
        }
    }
}
void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],7:f2}");
        }
        Console.WriteLine();
    }
}

double[,] array2d = new double[3, 3];
FillArray2D(array2d);
PrintArray2D(array2d);
