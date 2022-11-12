/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
 (делится ли оно на два без остатка)*/

 Console.Write("Введите число для проверки четности ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}