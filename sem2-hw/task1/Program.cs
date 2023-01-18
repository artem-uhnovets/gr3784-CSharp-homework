// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int a = 456;
int b = 782;
int c = 918;
int resultA = (a/10)%10;
Console.WriteLine($"У 3-х значного числа {a} 2-ой цифрой является {resultA}");
int resultB = (b/10)%10;
Console.WriteLine($"У 3-х значного числа {b} 2-ой цифрой является {resultB}");
int resultC = (c/10)%10;
Console.WriteLine($"У 3-х значного числа {c} 2-ой цифрой является {resultC}");

// Console.Clear();
// int a = new Random().Next(100,1000);
// int b = new Random().Next(100,1000);
// int c = new Random().Next(100,1000);
// int resultA = (a/10)%10;
// Console.WriteLine($"У 3-х значного числа {a} 2-ой цифрой является {resultA}");
// int resultB = (b/10)%10;
// Console.WriteLine($"У 3-х значного числа {b} 2-ой цифрой является {resultB}");
// int resultC = (c/10)%10;
// Console.WriteLine($"У 3-х значного числа {c} 2-ой цифрой является {resultC}");


// Console.Clear();
// string a;
// string b;
// string c;

// do {
//     Console.Write("Введите 1-ое число ");
//     a = Console.ReadLine();
//     if (a.Length != 3) 
//     {
//         Console.WriteLine("Введите пожалуйста именно ТРЕХ значное число!");
//     }
// } while(a.Length != 3);

// do {
//     Console.Write("Введите 2-ое число ");
//     b = Console.ReadLine();
//     if (b.Length != 3) 
//     {
//         Console.WriteLine("Введите пожалуйста именно ТРЕХ значное число!");
//     }
// } while(b.Length != 3);

// do {
//     Console.Write("Введите 3-ье число ");
//     c = Console.ReadLine();
//     if (c.Length != 3) 
//     {
//         Console.WriteLine("Введите пожалуйста именно ТРЕХ значное число!");
//     }
// } while(c.Length != 3);

// int resultA = (int.Parse(a)/10)%10;
// Console.WriteLine($"У 3-х значного числа {a} 2-ой цифрой является {resultA}");
// int resultB = (int.Parse(b)/10)%10;
// Console.WriteLine($"У 3-х значного числа {b} 2-ой цифрой является {resultB}");
// int resultC = (int.Parse(c)/10)%10;
// Console.WriteLine($"У 3-х значного числа {c} 2-ой цифрой является {resultC}");


// Console.Clear();
// int a;
// int b;
// int c;

// do {
//     Console.Write("Введите 1-ое число ");
//     a = int.Parse(Console.ReadLine());
//     if (a<100 || a>999) 
//     {
//         Console.WriteLine("Введите пожалуйста именно ТРЕХ значное число!");
//     }
// } while(a<100 || a>999);

// do {
//     Console.Write("Введите 2-ое число ");
//     b = int.Parse(Console.ReadLine());
//     if (b<100 || b>999) 
//     {
//         Console.WriteLine("Введите пожалуйста именно ТРЕХ значное число!");
//     }
// } while(b<100 || b>999);

// do {
//     Console.Write("Введите 3-ье число ");
//     c = int.Parse(Console.ReadLine());
//     if (c<100 || c>999) 
//     {
//         Console.WriteLine("Введите пожалуйста именно ТРЕХ значное число!");
//     }
// } while(c<100 || c>999);

// int resultA = (a/10)%10;
// Console.WriteLine($"У 3-х значного числа {a} 2-ой цифрой является {resultA}");
// int resultB = (b/10)%10;
// Console.WriteLine($"У 3-х значного числа {b} 2-ой цифрой является {resultB}");
// int resultC = (c/10)%10;
// Console.WriteLine($"У 3-х значного числа {c} 2-ой цифрой является {resultC}");