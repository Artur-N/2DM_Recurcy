// 3. Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение элементов, кратных 3 и 5.

void SetArr2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i, j] = rnd.Next(15, 91);
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


void Task03(int[,] arr, out int sum, out int multi)
{
    sum = 0;
    multi = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 15 == 0)
            {
                sum += arr[i, j];
                multi *= arr[i, j];
            }
        }
    }
}

int[,] Arr2D = new int[3, 4];
SetArr2D(Arr2D);
Print(Arr2D);
int s, m;
Task03(Arr2D, out s, out m);
if (s > 0 && m > 1)
{
    Console.WriteLine($"Сумма элементов кратных 3 и 5 = {s}");
    Console.WriteLine($"Произведение элементов кратных 3 и 5 = {m}");
}
else
{
    Console.WriteLine("Таких элементов нет");
}
