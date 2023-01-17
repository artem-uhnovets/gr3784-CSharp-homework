// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
int a1 = 5, b1 = 7;
int a2 = 2, b2 = 10;
int a3 = -9, b3 = -3;
int max1 = 0, max2 = 0, max3;
if (a1>b1) max1 = a1;
else max1=b1;
Console.WriteLine($"{max1} это максимальное число из {a1} и {b1}.");
if (a2>b2) max2 = a2;
else max2=b2;
Console.WriteLine($"{max2} это максимальное число из {a2} и {b2}.");
if (a3>b3) max3 = a3;
else max3=b3;
Console.WriteLine($"{max3} это максимальное число из {a3} и {b3}.");

// Console.Clear();
// int a = new Random().Next(1,1000000001);
// int b = new Random().Next(1,1000000001);
// int max = 0;
// if (a>b) max = a;
// else max=b;
// Console.WriteLine($"{max} это максимальное число из {a} и {b}.");

// Console.Clear();
// Console.WriteLine("Необходимо ввести 2 любых числа.");
// Console.Write("Введите 1ое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите 2ое число: ");
// int b = int.Parse(Console.ReadLine());
// int max = 0;
// if (a>b) max = a;
// else max=b;
// Console.WriteLine($"{max} это максимальное число из {a} и {b}.");