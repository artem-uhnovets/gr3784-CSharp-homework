// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
int a1 = 2, b1 = 3, c1 = 7;
int a2 = 44, b2 = 5, c2 = 78;
int a3 =22, b3 = 3, c3 = 9;
int max1 = a1, max2 = a2, max3 = a3;
if (b1>a1) 
{
    max1 = b1;
    if (c1>b1) max1 = c1;
}
else if (c1>a1) max1 = c1;
Console.WriteLine($"{max1} это максимальное число из {a1}, {b1} и {c1}.");
if (b2>a2) 
{
    max2 = b2;
    if (c2>b2) max2 = c2;
}
else if (c2>a2) max2 = c2;
Console.WriteLine($"{max2} это максимальное число из {a2}, {b2} и {c2}.");
if (b3>a3) 
{
    max3 = b3;
    if (c3>b3) max3 = c3;
}
else if (c3>a3) max3 = c3;
Console.WriteLine($"{max3} это максимальное число из {a3}, {b3} и {c3}.");

// Console.Clear();
// int a = new Random().Next(1,1000000001);
// int b = new Random().Next(1,1000000001);
// int c = new Random().Next(1,1000000001);
// int max = a;
// if (b>a) 
// {
//     max = b;
//     if (c>b) max = c;
// }
// else if (c>a) max = c;
// Console.WriteLine($"{max} это максимальное число из {a}, {b} и {c}.");

// Console.Clear();
// Console.WriteLine("Необходимо ввести 3 любых числа.");
// Console.Write("Введите 1ое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите 2ое число: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите 3ье число: ");
// int c = int.Parse(Console.ReadLine());
// int max = a;
// if (b>a) 
// {
//     max = b;
//     if (c>b) max = c;
// }
// else if (c>a) max = c;
// Console.WriteLine($"{max} это максимальное число из {a}, {b} и {c}.");