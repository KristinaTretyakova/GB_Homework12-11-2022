/*  Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n. */

int n = ReadInt("Введите число N: ");
int m = ReadInt("Введите число M: ");

FunctionAkkerman(n,m);

void FunctionAkkerman(int a, int b)
{
    Console.Write(Akkerman(a, b)); 
}


int Akkerman(int a,int b)
{
    if (a == 0)
    {   
        return b + 1;
    }
    else if (a > 0 && b == 0)
    {
        return Akkerman(a - 1, 1);
    }
    else 
    {
       return Akkerman (a - 1, Akkerman(a,b-1));
    }
}

int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }