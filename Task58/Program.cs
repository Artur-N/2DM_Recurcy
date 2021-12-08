// 58 Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

void FillArray(int[,] array)
{
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = n + 1;
            n++;
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

int[,] ChangeStringColumn(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Замена невозможна, т.к. матрица не квадратная!");
    }
    int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array.GetLength(0) == array.GetLength(1)) arr[j, i] = array[i, j];
            else break;
        }
    }
    return arr;
}

int[,] array2D = new int[5, 5];
FillArray(array2D);
PrintArray(array2D);
Console.WriteLine();
PrintArray(ChangeStringColumn(array2D));