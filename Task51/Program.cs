// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = m + n;
        }

    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($" {array[m, n],3}");
        }
        Console.WriteLine();
    }
}
int[,] array = new int[11, 11];
FillArray(array);
PrintArray(array);