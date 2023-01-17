// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
int a = 4;
int b = -3;
int c = 7;
if (a%2 == 0) Console.WriteLine($"Число {a} является четным.");
else Console.WriteLine($"Число {a} НЕ является четным.");
if (b%2 == 0) Console.WriteLine($"Число {b} является четным.");
else Console.WriteLine($"Число {b} НЕ является четным.");
if (c%2 == 0) Console.WriteLine($"Число {c} является четным.");
else Console.WriteLine($"Число {c} НЕ является четным.");

// Console.Clear();
// Console.WriteLine("Необходимо ввести 3 числа");
// Console.Write("Введите 1ое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите 2ое число: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите 3ье число: ");
// int c = int.Parse(Console.ReadLine());
// if (a%2 == 0) Console.WriteLine($"Число {a} является четным.");
// else Console.WriteLine($"Число {a} НЕ является четным.");
// if (b%2 == 0) Console.WriteLine($"Число {b} является четным.");
// else Console.WriteLine($"Число {b} НЕ является четным.");
// if (c%2 == 0) Console.WriteLine($"Число {c} является четным.");
// else Console.WriteLine($"Число {c} НЕ является четным.");

// Console.Clear();
// int a = new Random().Next(1,1000000001);
// Console.WriteLine($"1-ое число равно {a}.");
// int b = new Random().Next(1,1000000001);
// Console.WriteLine($"2-ое число равно {b}.");
// int c = new Random().Next(1,1000000001);
// Console.WriteLine($"3-ье число равно {c}.");
// if (a%2 == 0) Console.WriteLine($"Число {a} является четным.");
// else Console.WriteLine($"Число {a} НЕ является четным.");
// if (b%2 == 0) Console.WriteLine($"Число {b} является четным.");
// else Console.WriteLine($"Число {b} НЕ является четным.");
// if (c%2 == 0) Console.WriteLine($"Число {c} является четным.");
// else Console.WriteLine($"Число {c} НЕ является четным.");