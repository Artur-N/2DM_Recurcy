// 60 Составить частотный словарь элементов двумерного массива

Random rnd = new Random();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] array2D = new int[3,4];
FillArray(array2D);
PrintArray(array2D);
Dictionary<int, int> freqArray = new Dictionary<int, int>();
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        if (freqArray.ContainsKey(array2D[i,j])) freqArray[array2D[i,j]]++;
        else freqArray.Add(array2D[i,j],1);
    }
}
foreach (var element in freqArray)
{
    System.Console.Write(element + " ");
}

