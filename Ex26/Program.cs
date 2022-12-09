/*Напишите программу, которая заполнит спирально массив 4 на 4.*/

int size = ReadInt("Введите размер массива (по условию 4):  ");

int [,] numbers = new int [size,size];

int number = 1;
int i = 0;
int j = 0;

while(number <= size*size)
{
    numbers[i,j] = number;
    if(i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++number;  
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("  " + array[i, j] + "  ");
        }
        Console.WriteLine("");
    }
}

int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }