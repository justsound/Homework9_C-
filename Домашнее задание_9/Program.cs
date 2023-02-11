Console.Clear();

/* //Показать натуральные числа от N до 1, N задано

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

void PrintNumber(int n)
{
    if (0 < n)
    {
        Console.Write(n + " ");
        PrintNumber(n - 1);
    }
}
PrintNumber(n);  
 */
/*  //Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());

void PrintNumber(int n, int m)
{
    if (m > n)
    {
        Console.Write(m + " ");
        PrintNumber(n, m - 1);
    }
    else if (m < n)
    {
        PrintNumber(n-1, m );
        Console.Write(n + " ");
    }
    else if (n == m) Console.Write(n + " ");
}

PrintNumber(n, m);  */

// Найти сумму элементов от M до N, N и M заданы

/* Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());

int Sum(int n, int m)
{
    if(n == m) return m;
    return m + Sum(n, m -1);
}
if ( n< m) Console.WriteLine(Sum(n,m));
else Console.WriteLine(Sum(m,n)); */

/* // Написать программу вычисления функции Аккермана
// A(m,n) = {n+1, m=0 || A(m-1,1) m>0, n=0 || A(m,n-1), m>0, n>0

Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

int Akkerman(int m, int n)
{
    {
        if (m == 0) return n + 1;
        else if (n == 0) return (Akkerman(m - 1, 1));
        else return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
Console.WriteLine(Akkerman(m,n)); */

// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
//2 3 5 8 13

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  второе число");
int b = int.Parse(Console.ReadLine()!);

/*//int Factorial(int a, int b, int n)
//{
//     if (n == 1) return a;
//     if (n == 2) return b;
//     else return Factorial(a, b, n-1) + Factorial(a, b, n - 2);
// }
 */

void PrintFactorial(int a, int b, int n)
{
    int temp = 0;
    if (n > 0)
    {
        Console.Write(a + " ");
        temp = a;
        a = b;
        b = temp + b;
        PrintFactorial(a, b, n - 1);
    }
}
PrintFactorial( a,  b,  n);