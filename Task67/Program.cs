// 67 Показать натуральные числа от N до 1, N задано

string NaturalN1(int n)
{
    if (n == 1) return $"{n} ";
    else return $"{n} " + NaturalN1(n - 1);
}

int N = 10;
Console.WriteLine(NaturalN1(N));
