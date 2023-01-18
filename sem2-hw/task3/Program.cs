// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
int day;
do {
    Console.Write("Введите день недели числом ");
    day = int.Parse(Console.ReadLine());
    if (day<1 || day>7) Console.WriteLine("В неделе 7 дней, пожалуйста введите число от 1 до 7.");
} while (day<1 || day>7);
if (day==6 || day==7) Console.WriteLine($"{day} является выходным.");
else Console.WriteLine($"{day} НЕ является выходным.");


// Console.Clear();
// string day;
// do {
//     Console.Write("Введите день недели числом ");
//     day = Console.ReadLine();
//     if (int.Parse(day)<1 || int.Parse(day)>7) Console.WriteLine("В неделе 7 дней, пожалуйста введите число от 1 до 7.");
// } while (int.Parse(day)<1 || int.Parse(day)>7);
// if (int.Parse(day)==6 || int.Parse(day)==7) Console.WriteLine($"{day} является выходным.");
// else Console.WriteLine($"{day} НЕ является выходным.");


// Console.Clear();
// Console.Write("Введите день недели числом ");
// int day = int.Parse(Console.ReadLine());
// if (day>=1 && day<=7)
// {
//     if (day==6 || day==7) Console.WriteLine($"{day} является выходным.");
//     else Console.WriteLine($"{day} НЕ является выходным.");
// }
// else Console.WriteLine("В неделе 7 дней.");


// Console.Clear();
// Console.Write("Введите день недели числом ");
// string day = Console.ReadLine();
// if (day=="1" || day=="2" || day=="3" || day=="4" || day=="5" || day=="6" || day=="7")
// {
//     if (day=="6" || day=="7") Console.WriteLine($"{day} является выходным.");
//     else Console.WriteLine($"{day} НЕ является выходным.");
// }
// else Console.WriteLine("В неделе 7 дней.");