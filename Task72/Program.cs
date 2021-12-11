// 72 Написать программу возведения числа А в целую стень B

int Power(int a, int b)
{
    if (b == 0) return 1;
    else return Power(a, b - 1) * a;
}

System.Console.WriteLine(Power(3, 3));
