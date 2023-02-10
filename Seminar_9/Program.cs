Console.Clear();
/* //Показать натуральные числа от 1 до N, N задано

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

void PrintNumber(int n)
{
    if (0 < n)
    {
        PrintNumber(n - 1);
        Console.Write(n + " ");
    }
}
PrintNumber(n); */

/* // Найти сумму цифр числа

int Sum(int num)
{
    if(num < 10) return num;
    return num%10 + Sum(num/10);
}

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Sum(n)); */

// Написать программу возведения числа А в целую стень B
Console.WriteLine("Введите a:");

int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine()!);

int MathPow( int a, int b)
{
    if(b == 0) return 1;
    return a * MathPow( a, b - 1);
}
Console.WriteLine(MathPow (a, b));
