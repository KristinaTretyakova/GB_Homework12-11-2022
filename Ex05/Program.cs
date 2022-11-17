/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.*/

Console.Write("Введите трехзначное число ");
int threenumber = Convert.ToInt32(Console.ReadLine());
int secondnumber = (threenumber % 100) / 10;

if(threenumber > 99 && threenumber < 1000)
{
    Console.WriteLine($"Ваше число {threenumber},а вторая цифра этого числа равна {secondnumber}");
}
else
{
    Console.WriteLine(" Вы ввели не трехзначное число,повторите попытку:)");
}
