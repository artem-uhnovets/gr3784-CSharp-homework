// Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int GetNum(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int CubeNum(int number)
{
    int result = 0;
    for (int count = 1; count <= number; count++)
    {
        result = count * count * count;
        if (count == number) Console.Write($"{result}");
        else Console.Write($"{result}, ");
    }
    return result;
}

int number = GetNum("Введите число ");
CubeNum(number);