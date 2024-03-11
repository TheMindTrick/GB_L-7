/* ############################ Задача №2 ############################
    Задача 2: Напишите программу вычисления функции Аккермана с 
    помощью рекурсии. Даны два неотрицательных числа m и n...
################################################################### */

void Main()
{
    int m = ReadInt("Введите число m: ");
    int n = ReadInt("Введите число n: ");

    while (m < 0 || n < 0)
    {
        System.Console.WriteLine("Числа m и n должны быть неотрицательными!");
        m = ReadInt("Введите число m: ");
        n = ReadInt("Введите число n: ");
    }

    System.Console.WriteLine(AckermannFunction(m, n));
}

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 & n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else if (m > 0 & n > 0)
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else return 0;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
