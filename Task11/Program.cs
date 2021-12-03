// 11. Дан целочисленный двумерный массив, размерности n х m. Вывести его элементы, индексы которых являются степенями двойки (1, 2, 4, 8, 16, ...).

Random rnd = new Random();
void FillArray(int[,] array)
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

void Task11(int[,] array)
{
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == (int)Math.Pow(2, n) && j == (int)Math.Pow(2, n))
            {
                Console.WriteLine($"{i},{j} - {array[i, j]}");
                n++;
            }
        }
    }
}
int[,] array2D = new int[10, 10];
FillArray(array2D);
PrintArray(array2D);
Task11(array2D);