/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int[,] numbers = new int[rows , columns]; 

FillMatrixRandomNumbers(numbers);

Console.WriteLine("По Вашим параметрам был сгенерирован массив : ");
Console.WriteLine();
WriteMatrix(numbers);

int rowsNumber = ReadInt("Введите индекс строки: ");
int columnsNumber = ReadInt("Введите индекс столбца: ");
 

if (rowsNumber < numbers.GetLength(0) && columnsNumber < numbers.GetLength(1)) Console.WriteLine($"Число в массиве по тем индексам, что Вы ввели равно {numbers[rowsNumber, columnsNumber]}");
else Console.WriteLine($"{rowsNumber}{columnsNumber} -> числа с такой позицией в массиве нет");

void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
        for(int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }