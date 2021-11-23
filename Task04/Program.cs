// 4. Дан целочисленный двумерный массив, размерности n х m. Найти количество отрицательных элементов, больше -9.

void SetArr2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random Rnd = new Random();
            arr[i, j] = Rnd.Next(-15, 5);
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

void Task04(int[,] arr, out int count)
{
    count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] > -9 && arr[i,j] < 0)
            {
                count++;
            }
        }
    }
}

int[,] Array2D = new int[3, 4];
SetArr2D(Array2D);
Print(Array2D);
int c;
Task04(Array2D, out c);
Console.WriteLine($"Количество отрицательных элементов больше -9 = {c}");

