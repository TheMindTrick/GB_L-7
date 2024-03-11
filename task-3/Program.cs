/* ############################ Задача №3 ############################
    Задача 3: Задайте произвольный массив. Выведете его элементы,
    начиная с конца. Использовать рекурсию, не использовать циклы.
################################################################### */

void Main()
{
    int[] numbers = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };

    PrintNumbers(numbers, 0);
}

void PrintNumbers(int[] numbers, int index)
{
    if (index == numbers.Length) return;
    PrintNumbers(numbers, index + 1);
    System.Console.Write(numbers[index] + " ");
}

Main();
