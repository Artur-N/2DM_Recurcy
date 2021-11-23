// 5. Дан целочисленный двумерный массив, размерности n х m. Найти номера нечетных элементов, стоящих на четных местах. 

void SetArr2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i, j] = rnd.Next(-10, 11);
        }
    }
}
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}");
        }
        Console.WriteLine();
    }
}

void Task05(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 2 != 0 && i % 2 == 0 && j % 2 == 0)
            {
                Console.WriteLine($"Нечётный элемент {arr[i, j]} стоит на чётной позиции {i},{j}");
            }
        }
    }
}
int[,] Arr2D = new int[5, 6];
SetArr2D(Arr2D);
Print(Arr2D);
Task05(Arr2D);

