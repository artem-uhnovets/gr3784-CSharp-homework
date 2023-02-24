// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int SummNumRecur(int lower, int upper)
{
    if (lower == upper) return lower;
    else return upper + SummNumRecur(lower, upper - 1);
}

int GetNumber(string text)
{
    Console.Write(text);
    string size = Console.ReadLine();
    while (String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.WriteLine(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int numberA = GetNumber("Введите начало промежутка - ");
int numberB = GetNumber("Введите конец  промежутка - ");
Console.WriteLine($"M = {numberA}; N = {numberB} -> {SummNumRecur(numberA, numberB)}");