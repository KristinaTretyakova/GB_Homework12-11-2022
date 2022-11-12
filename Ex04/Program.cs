/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.*/

int numberA = 1; //Начало диапазона;

Console.Write("Введите максимальное число диапазона ");
int numberB = Convert.ToInt32(Console.ReadLine());

int a = numberA;

while ( a <= numberB)
{
    if ( a % 2 == 0)
    {
    Console.Write( a + " ");
    }
    a++;
}