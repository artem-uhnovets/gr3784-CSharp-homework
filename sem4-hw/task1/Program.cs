// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int PowerNumber(int number, int power)
{
    int result = number;
    if (power == 1) result = number;
    else for (int count = 2; count <= power; count++)
        {
            result = result * number;
        }
    return result;
}

int number = GetNumber("Введите число для возведения в степень:");
int power = GetNumber("Введите степень:");
int result = PowerNumber(number, power);
Console.WriteLine($"{number}, {power} -> {result}");