// 52 В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

void ChangeEvenIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] *= array[i, j];
                //array[i, j] = (int)Math.Pow(array[i, j], 2);
        }
    }
}
int[,] array2D = new int[5, 5];
FillArray(array2D);
PrintArray(array2D);
System.Console.WriteLine();
ChangeEvenIndex(array2D);
PrintArray(array2D);