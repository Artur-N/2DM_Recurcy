// 71 Написать программу вычисления функции Аккермана

int i = 0;
int A(int m, int n)
{
    i++;
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return A(m, n);
}

System.Console.WriteLine(A(3, 5));
System.Console.WriteLine(i);