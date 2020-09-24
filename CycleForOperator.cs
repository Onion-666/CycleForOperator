using System;
class Programm
{
    static void Main()
    {
        int n = 10, i, s;
        Console.Write("Сумма первых дести нечетных чисел");
        for (i = 1, s = 0; i <= n; s += 2 * i - 1, i++) 
            Console.WriteLine(s);
        Console.WriteLine(s);
    }
}
/*
        int s = 0, n = 10;
        Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);
        for (int i = 1; i <= n; i++)
            s += 2 * i - 1;
        Console.WriteLine(s);
 */
