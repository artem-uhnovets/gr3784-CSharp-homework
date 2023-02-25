// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// ЕСЛИ ИМЕЕТСЯ ВВИДУ КВАДРАТНЫЙ - РАВНОСТОРОННИЙ ДВУМЕРНЫЙ МАССИВ, ТО СТРОКИ И СТОЛБЦЫ БУДУТ РАВНЫ

Console.Clear();

void FindLowerSumm(int[,] array)
{
    int[] arraySumm = new int[array.GetLength(0)];
    int min = 2147483647;
    int minIndex = 0;
    Console.WriteLine("Сумма элементов по строкам");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++) summ += array[i, j];
        arraySumm[i] = summ;
        if (arraySumm[i] < min)
        {
            min = arraySumm[i];
            minIndex = i;
        }
        Console.Write("{0,5} -", i);
        Console.WriteLine("{0,3}", arraySumm[i]);
    }
    Console.WriteLine();
    Console.WriteLine($"{minIndex+1} строка с индексом {minIndex} с наименьшей суммой элементов.");
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5}", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    string size = Console.ReadLine();
    while (int.TryParse(size, out _) == false || String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.WriteLine(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int size = GetSize("Введите кол-во строк и столбцов ");
int[,] array = GetArray(size, size, 0, 10);
PrintArray(array);
FindLowerSumm(array);