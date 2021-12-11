// 66 Показать натуральные числа от 1 до N, N задано

string Natural1N(int a)
{
    if (a == 1) return $"{a} ";
    else return Natural1N(a - 1) + $"{a} ";
}
Console.WriteLine(Natural1N(10));
