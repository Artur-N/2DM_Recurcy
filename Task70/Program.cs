// 70 Найти сумму цифр числа

int SummaNumber(int n)
{
    if (n == 0) return 0;
    else return n % 10 + SummaNumber(n / 10);
}

System.Console.WriteLine(SummaNumber(12345));
