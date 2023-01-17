// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
int a = 5;
int b = 8;
int count1 = 0;
int count2 = 0;
Console.Write($"Все четные числа по {a}: ");
while (count1 <= a)
{
    if (count1 == 0)
    {
        count1++;
    }
    else if (count1%2 == 0) 
    {
        Console.Write(" " + count1);
        count1++;
    }
    else count1++;
}
Console.WriteLine(" ");
Console.Write($"Все четные числа по {b}: ");
while (count2 <= b)
{
    if (count2 == 0)
    {
        count2++;
    }
    else if (count2%2 == 0) 
    {
        Console.Write(" " + count2);
        count2++;
    }
    else count2++;
}

// Console.Clear();
// Console.WriteLine("Необходимо ввести два числа.");
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine());
// int count1 = 0;
// int count2 = 0;
// Console.Write($"Все четные числа по {a}: ");
// while (count1 <= a)
// {
//     if (count1 == 0)
//     {
//         count1++;
//     }
//     else if (count1%2 == 0) 
//     {
//         Console.Write(" " + count1);
//         count1++;
//     }
//     else count1++;
// }
// Console.WriteLine(" ");
// Console.Write($"Все четные числа по {b}: ");
// while (count2 <= b)
// {
//     if (count2 == 0)
//     {
//         count2++;
//     }
//     else if (count2%2 == 0) 
//     {
//         Console.Write(" " + count2);
//         count2++;
//     }
//     else count2++;
// }

// Console.Clear();
// Console.WriteLine("В случайном порядке будет сгенерировано 2 числа.");
// int a = new Random().Next(1,101);
// int b = new Random().Next(1,101);
// int count1 = 0;
// int count2 = 0;
// Console.Write($"Все четные числа по {a}: ");
// while (count1 <= a)
// {
//     if (count1 == 0)
//     {
//         count1++;
//     }
//     else if (count1%2 == 0) 
//     {
//         Console.Write(" " + count1);
//         count1++;
//     }
//     else count1++;
// }
// Console.WriteLine(" ");
// Console.Write($"Все четные числа по {b}: ");
// while (count2 <= b)
// {
//     if (count2 == 0)
//     {
//         count2++;
//     }
//     else if (count2%2 == 0) 
//     {
//         Console.Write(" " + count2);
//         count2++;
//     }
//     else count2++;
// }