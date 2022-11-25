/*Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
Вывод сделать отдельным методом.*/

int ArrayLen = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[ArrayLen];

for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

