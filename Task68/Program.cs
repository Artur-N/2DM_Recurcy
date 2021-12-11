// 68 Показать натуральные числа от M до N, N и M заданы

string NumbersMN(int a, int b)
{
    if (a < b) return $"{a} " + NumbersMN(a + 1, b);
    else if (a > b) return $"{a} " + NumbersMN(a - 1, b);
    return $"{b}";
}

int M = 20;
int N = 5;
System.Console.WriteLine(NumbersMN(M, N));
