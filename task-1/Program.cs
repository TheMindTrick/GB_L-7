/* ############################ Задача №1 ############################
    Задача 1: Задайте значения M и N. Напишите программу, которая
    выведет все натуральные числа в промежутке от M до N.
    Использовать рекурсию, не использовать циклы.
################################################################### */

void Main()
{
    int M = ReadInt("Введите начальную границу промежутка - M: ");
    int N = ReadInt("Введите конечную границу промежутка - N: ");

    while (M > N || M == N)
    {
        System.Console.WriteLine("Ваш диапазон не верен. Число M должно быть меньше N.");
        M = ReadInt("Введите начальную границу промежутка - M: ");
        N = ReadInt("Введите конечную границу промежутка - N: ");
    }
    PrintNumbers(M + 1, N);
}

void PrintNumbers(int M, int N)
{
    if (M == N) return;
    if (M >= 0) System.Console.Write(M + " ");
    PrintNumbers(M + 1, N);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();