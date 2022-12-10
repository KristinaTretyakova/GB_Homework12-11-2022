/*  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии. */

int n = ReadInt("Введите число N: ");
int end = 1;

NaturalNumber(n,end);

void NaturalNumber(int a, int b)

{
    if (a == b)
    {
        Console.Write($"{a}");
    }
    if (a<b)
    {
        Console.Write($"{a}, ");
        NaturalNumber(a+1,b);
    }
    if (a>b)
    {
        Console.Write($"{a}, ");
        NaturalNumber(a-1,b);
    }
}

int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }