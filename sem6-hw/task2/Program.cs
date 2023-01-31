// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// y - y = k1 * x + b1 - k2 * x - b2
// 0 = k1 * x + b1 - k2 * x - b2
// k1 * x - k2 * x = b2 - b1
// x * (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

void CrossLines(float b1, float k1, float b2, float k2)
{
    float numX = (b2 - b1) / (k1 - k2);
    float numY1 = k1 * numX + b1;
    float numY2 = k2 * numX + b2;
    if (numY1 == numY2)
    {
        Console.WriteLine($"({numX}; {numY1})");
    }
    else Console.WriteLine("Lines don't cross.");
}

int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

float numberB1 = GetNum("Введите число B1 - ");
float numberK1 = GetNum("Введите число K1 - ");
float numberB2 = GetNum("Введите число B2 - ");
float numberK2 = GetNum("Введите число K2 - ");
Console.Write($"b1 = {numberB1}, k1 = {numberK1}, b2 = {numberB2}, k2 = {numberK2} -> ");
CrossLines(numberB1, numberK1, numberB2, numberK2);
