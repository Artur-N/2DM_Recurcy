// 6. Дан целочисленный двумерный массив, размерности n х m. Найти максимум и минимум. Поменять их местами.

Random rnd = new Random();
void SetArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 100);
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

void MinMax(int[,] array, out int min, out int max)
{
    int i = 0;
    int j = 0;
    min = array[i, j];
    max = array[i, j];
    int mini = 0;
    int minj = 0;
    int maxi = 0;
    int maxj = 0;
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                mini = i;
                minj = j;
            }
            if (array[i, j] > max)
            {
                max = array[i, j];
                maxi = i;
                maxj = j;
            }
        }
    }
    array[mini, minj] = max;
    array[maxi, maxj] = min;
}


int[,] array2D = new int[3, 3];
int min, max;
SetArray2D(array2D);
PrintArray(array2D);
MinMax(array2D, out min, out max);
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Максимальное значение = {max}");
PrintArray(array2D);


