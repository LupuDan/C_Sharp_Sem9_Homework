/*
    Задача 66: Задайте значения M и N.
    Напишите программу, которая найдёт сумму
    натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int M = 1;
        int N = 100;
        int sum = 0;

        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", M, N, sum);
    }
}