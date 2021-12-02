// 7. Дан целочисленный двумерный массив, размерности n х m. Заменить все элементы на их квадраты.

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

void Task07(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = (int)Math.Pow(array[i,j],2);
        }
    }
}

int[,] array2D = new int[3,3];
SetArray2D(array2D);
PrintArray(array2D);
Console.WriteLine();
Task07(array2D);
PrintArray(array2D);
