// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение четных элементов.
void SetArray2D(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=i*10+j+1;
        }
    }
}


void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    }
}

//Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение четных элементов.
void Task02(int[,] a,out int sum,out int multi)
{   
    sum=0;
    multi=1;
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
        if (a[i,j]%2==0) {sum=sum+a[i,j]; multi=multi*a[i,j];}
        }
    }
}



int[,] a;
a=new int[3,4];


SetArray2D(a);
Print(a);
int s,m;
Task02(a,out s,out m);
Console.WriteLine ($"{s}  {m}");

//Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение элементов, кратных 3 и 5.
 void Task03(int[,] a,out int sum,out int multi)
{   
    sum=0;
    multi=1;
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
        if (a[i,j]%3==0 && a[i,j]%5==0) {sum=sum+a[i,j]; multi=multi*a[i,j];}
        }
    }
}
//Дан целочисленный двумерный массив, размерности n х m. Найти количество отрицательных элементов, больше -9.

 void Task04(int[,] a,out int count)
{   
    count=0;
   
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
        if (a[i,j]>-9 && a[i,j]<0) {count+=1;} // count=count+1;
        }
    }
}
//Дан целочисленный двумерный массив, размерности n х m. Найти номера нечетных элементов, стоящих на четных местах. 
 void Task05(int[,] a)
{   
    
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
        if (i%2==0 && j%2==0 && a[i,j]%2!=0) {Console.WriteLine($"{i,2},{j,2} = {a[i,j],4}");} 
        }
    }
}
