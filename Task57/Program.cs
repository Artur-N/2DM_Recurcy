// 57 Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
            Console.Write($"{array[i, j],3}");
        }
        Console.WriteLine();
    }
}

void ExchangeStrings(int[,] array)
{
    int s;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j + 1] > array[i, j])
            {
                s = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = s;
            }
        }
    }
}

int[,] array2D = new int[4, 5];
FillArray(array2D);
PrintArray(array2D);
Console.WriteLine();
ExchangeStrings(array2D);
PrintArray(array2D);