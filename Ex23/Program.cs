/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

int[,] numbers = new int[4, 4];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
Console.WriteLine();
NumberRowMinSumElements(numbers);

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        minRow += numbers[0, i];
    }

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++) 
        {
            sumRow += numbers[i, j];

                if (sumRow < minRow)
                {
                    minRow = sumRow;
                    minSumRow = i;
                }

            sumRow = 0;
        }
    }
    Console.Write($"{minSumRow + 1} строка c наименьшей суммой элементов");
}

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