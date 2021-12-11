// 69 Найти сумму элементов от M до N, N и M заданы

int Summa(int m, int n)
{
    if (m==n) return n;
    else return m + Summa((m+1), n);
}

int M = 1;
int N = 10;
System.Console.WriteLine(Summa(M,N));
