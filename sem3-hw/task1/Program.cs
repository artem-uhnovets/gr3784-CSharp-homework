// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int GetNum(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    while (number.ToString().Length < 5 || number.ToString().Length > 5)
    {
        Console.WriteLine("Введите именно 5-тизначное число");
        number = int.Parse(Console.ReadLine());
    }
    return number;
}

void Palindrome(int number)
{
    if (number / 10000 == number % 10)
    {
        if (number / 1000 % 10 == number % 100 / 10)
        {
            Console.WriteLine($"{number} -> Да");
        }
        else Console.WriteLine($"{number} -> Нет");
    }
    else Console.WriteLine($"{number} -> Нет");    
}

int number = GetNum("Введите 5-ти значное число");
Palindrome(number);

// Console.WriteLine(12821 % 10);
// Console.WriteLine(12821 / 10000);

// Console.WriteLine(12821 % 100 / 10);
// Console.WriteLine(12821 / 1000 % 10);