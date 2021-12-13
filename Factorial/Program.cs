// Факториал

int Factorial(int n)
{
    if (n==1) return 1;
    else return n * Factorial(n-1);
}

int N = 5;
Console.Write(Factorial(N));
