/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

Console.Write("Введите число от 1 до 7  ");
int dayweek = Convert.ToInt32(Console.ReadLine());

if(dayweek > 0 && dayweek < 6)
{
    Console.WriteLine("К сожалению не выходной:(");
}
else if (dayweek > 5 && dayweek < 8)
{
    Console.WriteLine("Выходной:)");
}
else
{
    Console.WriteLine("Введите корректное число");
}