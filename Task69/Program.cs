// 69 Найти сумму элементов от M до N, N и M заданы

int Summa(int m, int n)
{
    if (m < n) return m + Summa((m + 1), n);
    if (m > n) return m + Summa((m - 1), n);
    else return m;
}

int M = 10;
int N = 5;
System.Console.WriteLine(Summa(M, N));
