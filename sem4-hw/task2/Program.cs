// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SummDigit(int number)
{
    int summ = 0;
    int tempnumber = number;
    for (int index = 0; index < number.ToString().Length; index++)
    {
        summ = summ + tempnumber%10;
        tempnumber = tempnumber/10;
    }
    return summ;
}

// int SummDigit(string number)
// {
//     int summ = 0;
//     int[] emptyarr = new int[number.Length];
//     for (int index = 0; index < number.Length; index++)
//     {
//         emptyarr[index] = int.Parse(number[index]);
//         summ = summ + emptyarr[index];
//         Console.WriteLine(number[index]);
//         Console.WriteLine(summ);
//     }
//     return summ;
// }

int number = GetNumber("Введите число:");
int summ = SummDigit(number);
Console.WriteLine($"{number} -> {summ}");
