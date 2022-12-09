/*Cформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2 */

Console.WriteLine("Введите размер массива X x Y x Z: ");

int x = ReadInt("Введите X: (в задании 2) ");
int y = ReadInt("Введите Y: (в задании 2) ");
int z = ReadInt("Введите Z: (в задании 2) ");

int[,,] array3D = new int [x,y,z];

FillMatrixRandomNumbers(array3D);
WriteArray(array3D);


void WriteArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array3D[i,j,k]} ({i},{j},{k})  ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void FillMatrixRandomNumbers(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int count = 10; //так как в условии задачи двухзначные числа
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array3D[x, y, z] = count;
                count++;
            }
        }
    }
}

int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }