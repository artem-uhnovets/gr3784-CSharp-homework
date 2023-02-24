// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int AckermannFunction(int numA, int numB)
{
    if (numA == 0) return numB+1;
    else if (numB == 0) return AckermannFunction(numA-1, 1);
    else return AckermannFunction(numA - 1, AckermannFunction(numA, numB - 1));
}

int GetNumber(string text)
{
    Console.Write(text);
    string size = Console.ReadLine();
    while (String.IsNullOrEmpty(size) || int.Parse(size) < 0) { Console.Write(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int numberA = GetNumber("Введите 1ое неотриц. число - ");
int numberB = GetNumber("Введите 2ое неотриц. число - ");
Console.WriteLine($"m = {numberA}, n = {numberB} -> A(m,n) = {AckermannFunction(numberA, numberB)}");