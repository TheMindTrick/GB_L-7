/* ############################ Задача №3 ############################
    Задача 3: Задайте произвольный массив. Выведете его элементы,
    начиная с конца. Использовать рекурсию, не использовать циклы.
################################################################### */

void Main()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

    PrintNumbers(numbers, 0);
}

void PrintNumbers(int[] numbers, int index)
{
    if (numbers[index] == numbers.Length - 1) return;

    PrintNumbers(numbers, index + 1);

    System.Console.Write(numbers[index] + " ");
}

Main();
