/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
int result = 1;

for ( int i = 0; i< numberB; i++)

{
    result *=  numberA;
}

Console.WriteLine($"Число {numberA} в степени {numberB} равно = {result}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}