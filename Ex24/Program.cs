/*  Задайте две матрицы.
 Напишите программу, которая будет находить произведение двух матриц. */
int m = ReadInt("Введите количество строк в 1ой матрице: ");
int n = ReadInt("Введите количество столбцов в 1ой матрице (равно кол-ву строк во 2ой матрице ): ");
int k = ReadInt("Введите количество столбцов во 2ой матрице: ");

int[,] Matrix1 = new int[m, n];
int[,] Matrix2 = new int[n, k];
int[,] MatrixSum = new int[m, k];

FillMatrixRandomNumbers(Matrix1);
Console.WriteLine("Матрица 1: ");
WriteMatrix(Matrix1);
FillMatrixRandomNumbers(Matrix2);
Console.WriteLine("Матрица 2: ");
WriteMatrix(Matrix2);
MatrixSkalar(Matrix1,Matrix2,MatrixSum);
Console.WriteLine("Произведение 2х матриц равно: ");
WriteMatrix( MatrixSum);

void MatrixSkalar(int[,] array1,int[,] array2,int[,] arraySum)
{
    for(int i = 0; i < arraySum.GetLength(0); i++)
        {
        for(int j = 0; j < arraySum.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
               sum +=  array1[i,k] * array2[k,j];
            }
        arraySum[i,j] = sum;
        }
    }
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

int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }