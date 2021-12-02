// Дан целочисленный двумерный массив, размерности n х m. Выяснить, какое число встречается в какой строке раньше — положительное или отрицательное.

Random rnd = new Random();
void SetArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);
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

void Task09(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] > 0)
            {
                Console.WriteLine($"Положительное {i+1}");
                break;
            }
            else if (array[i,j] < 0)
            {
                Console.WriteLine($"Отрицательное {i+1}");
                break;
            }
        }
    }
}

int[,] array2D = new int[3,3];
SetArray2D(array2D);
PrintArray(array2D);
Console.WriteLine();
Task09(array2D);

