/*  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */

int n = ReadInt("Введите число N: ");
int m = ReadInt("Введите число M: ");
int sum = 0;
NaturalNumberSum(n,m);

void NaturalNumberSum(int a, int b)

{
    if (a == b)
    {   
        sum += a;
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    if (a<b)
    {
        sum += a;
        NaturalNumberSum(a+1,b);
    }
    if (a>b)
    {
        sum += a;
        NaturalNumberSum(a-1,b);
    }
}

int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }