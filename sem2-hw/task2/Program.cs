// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int a = 645;
int b = 78;
int c = 32679;
float digitA = 0;
float digitB = 0;
float digitC = 0;
if (a<100) Console.WriteLine($"{a} не 3-х значное число, третьей цифры нет");
else {digitA = (a-a%(MathF.Pow(10,(a.ToString().Length-3))))/MathF.Pow(10,(a.ToString().Length-3))%10;
      Console.WriteLine($"У числа {a} третьей цифрой является {digitA}");}
if (b<100) Console.WriteLine($"{b} не 3-х значное число, третьей цифры нет");
else {digitB = (b-b%(MathF.Pow(10,(b.ToString().Length-3))))/MathF.Pow(10,(b.ToString().Length-3))%10;
      Console.WriteLine($"У числа {b} третьей цифрой является {digitB}");}
if (c<100) Console.WriteLine($"{c} не 3-х значное число, третьей цифры нет");
else {digitC = (c-c%(MathF.Pow(10,(c.ToString().Length-3))))/MathF.Pow(10,(c.ToString().Length-3))%10;
      Console.WriteLine($"У числа {c} третьей цифрой является {digitC}");}
// MathF.Pow(x,y) метод возводит x в степень y, преобразует в тип float


// Console.Clear();
// string a = "645";
// string b = "78";
// string c = "32679";
// if (a.Length<3) Console.WriteLine($"{a} не 3-х значное число, третьей цифры нет");
// else Console.WriteLine($"У числа {a} третьей цифрой является {a[2]}");
// if (b.Length<3) Console.WriteLine($"{b} не 3-х значное число, третьей цифры нет");
// else Console.WriteLine($"У числа {b} третьей цифрой является {b[2]}");
// if (c.Length<3) Console.WriteLine($"{c} не 3-х значное число, третьей цифры нет");
// else Console.WriteLine($"У числа {c} третьей цифрой является {c[2]}");


// Console.Clear();
// Console.Write("Введите 1-ое число ");
// string a = Console.ReadLine();
// Console.Write("Введите 2-ое число ");
// string b = Console.ReadLine();
// Console.Write("Введите 3-ье число ");
// string c = Console.ReadLine();
// if (a.Length<3) Console.WriteLine($"{a} не 3-х значное число, третьей цифры нет");
// else Console.WriteLine($"У числа {a} третьей цифрой является {a[2]}");
// if (b.Length<3) Console.WriteLine($"{b} не 3-х значное число, третьей цифры нет");
// else Console.WriteLine($"У числа {b} третьей цифрой является {b[2]}");
// if (c.Length<3) Console.WriteLine($"{c} не 3-х значное число, третьей цифры нет");
// else Console.WriteLine($"У числа {c} третьей цифрой является {c[2]}");


// Console.Clear();
// Console.Write("Введите 1-ое число ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите 2-ое число ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите 3-ье число ");
// int c = int.Parse(Console.ReadLine());
// float digitA = 0;
// float digitB = 0;
// float digitC = 0;
// if (a<100) Console.WriteLine($"{a} не 3-х значное число, третьей цифры нет");
// else {digitA = (a-a%(MathF.Pow(10,(a.ToString().Length-3))))/MathF.Pow(10,(a.ToString().Length-3))%10;
//       Console.WriteLine($"У числа {a} третьей цифрой является {digitA}");}
// if (b<100) Console.WriteLine($"{b} не 3-х значное число, третьей цифры нет");
// else {digitB = (b-b%(MathF.Pow(10,(b.ToString().Length-3))))/MathF.Pow(10,(b.ToString().Length-3))%10;
//       Console.WriteLine($"У числа {b} третьей цифрой является {digitB}");}
// if (c<100) Console.WriteLine($"{c} не 3-х значное число, третьей цифры нет");
// else {digitC = (c-c%(MathF.Pow(10,(c.ToString().Length-3))))/MathF.Pow(10,(c.ToString().Length-3))%10;
//       Console.WriteLine($"У числа {c} третьей цифрой является {digitC}");}