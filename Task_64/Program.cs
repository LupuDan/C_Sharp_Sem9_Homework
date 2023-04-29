/*
    Задача 64: Задайте значение N.
    Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
    Выполнить с помощью рекурсии.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; // значение N

        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        if (n > 0)
        {
            Console.WriteLine(n);
            PrintNumbers(n - 1);
        }
    }
}