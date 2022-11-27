/*Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива. */

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"Задан массив из {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(10,1000)) / 100;
        }
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
        Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}
