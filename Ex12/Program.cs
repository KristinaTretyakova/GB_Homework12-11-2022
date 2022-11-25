/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

int number = ReadInt("Введите число: ");
int sum = 0;

while (number!=0)
{
    int temp = number % 10;
    number = number / 10;
    sum = sum + temp;
}

Console.WriteLine($"Сумма чисел введенного Вами числа равна {sum}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

