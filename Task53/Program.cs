// 53 В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Random rnd = new Random();
void FillArray(int[,] array, int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(m, n);
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

void IndexPlayerNumber(int[,] array, int s)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == s)
            {
                Console.WriteLine($"{i},{j}");
                k++;
            }
        }
    }
    if (k == 0) Console.WriteLine("Такого элемента нет!");
}

int[,] array2D = new int[3, 3];
int m = 1;
int n = 11;
FillArray(array2D, m, n);
PrintArray(array2D);
Console.Write($"Введите число от {m} до {n - 1}: ");
int s = Convert.ToInt32(Console.ReadLine());
IndexPlayerNumber(array2D, s);
