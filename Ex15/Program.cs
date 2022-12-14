/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
int sum = 0;
FillArrayRandomNumbers(numbers, -100 , 101);
WriteArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
    if ( i % 2 != 0)
    {
        sum = sum + numbers[i];
    }
}

Console.WriteLine(sum);

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
        Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}

int ReadInt(string message)
    {      Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }
