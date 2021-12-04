// 50. В двумерном массиве n×k заменить четные элементы на противоположные

Random rnd = new Random();
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
}
void PrintArray2D(int[,] array)
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

int[,] ChangeArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]%2==0) array[i, j] = -array[i,j];
        }
    }
return array;
}

int[,] array2d = new int[3, 3];
FillArray2D(array2d);
PrintArray2D(array2d);
System.Console.WriteLine();
ChangeArray2D(array2d);
PrintArray2D(array2d);