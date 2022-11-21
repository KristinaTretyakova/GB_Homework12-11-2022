/*Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.*/

int number = ReadInt("Введите число для проверки: ");
int temp = number;
int unnumber = 0;

while (temp > 0)
    {
        unnumber = unnumber * 10;
        unnumber = unnumber + temp % 10;
        temp = temp  / 10;
    }

if (number == unnumber)
{ 
    Console.WriteLine("Введенное Вами число является палиндромом");
}
else
{
    Console.WriteLine("Введенное Вами число НЕ является палиндромом");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}