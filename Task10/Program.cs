// 10. Дан целочисленный двумерный массив, размерности n х m. Выяснить, в какой строке последовательность является возрастающей или убывающей.

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

void Task10(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j + 1] > array[i, j])
            {
                Console.WriteLine("Последовательность возрастающая");
            break;
            }
            else if (array[i, j + 1] < array[i, j])
            {    Console.WriteLine("Последовательность убывающая");
            break;
            }
        }
    }
}

int[,] array2D = new int[3, 3];
SetArray2D(array2D);
PrintArray(array2D);
Task10(array2D);