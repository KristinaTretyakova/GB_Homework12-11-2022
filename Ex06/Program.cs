/*Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.*/

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 1000)
{
    number = number / 10;
}

int threenumber = (number % 10);

if( number > 99 && number < 1000)
{
    Console.WriteLine($"Третья цифра этого числа равна {threenumber}");
}
else
{
    Console.WriteLine(" Третьего числа нет:)");
}