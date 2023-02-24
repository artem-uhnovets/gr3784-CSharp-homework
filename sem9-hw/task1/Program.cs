// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

void PrintNaturalNumber(int number)
{
    if (number == 1) Console.Write("1");
    else { Console.Write("{0}, ", number); PrintNaturalNumber(number - 1); }
}

int GetNumber(string text)
{
    Console.Write(text);
    string size = Console.ReadLine();
    while (String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.Write(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int number = GetNumber("Введите кол-во чисел для вывода - ");
Console.Write("N = {0} -> ", number);
PrintNaturalNumber(number);