// 12. Дан целочисленный двумерный массив, размерности n х m. Найти количество элементов кратных 7.

Random rnd = new Random();
void FillArray(int[,] array)
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

void Task12(int[,] array, out int sum)
{
    sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 7 == 0)
            {
                Console.Write($"{array[i, j]}, ");
                sum++;
            }
        }
    }
   // return sum;
}
int[,] array2D = new int[5, 5];
int a;
FillArray(array2D);
PrintArray(array2D);
System.Console.Write("Элементы кратные 7: ");
Task12(array2D, out a);
System.Console.WriteLine();
Console.WriteLine($"Количество таких элементов = {a}");
