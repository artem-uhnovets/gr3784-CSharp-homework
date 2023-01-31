// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int CheckPstv(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0) count++;
    }
    return count;
}

int[] GetArray(int quantity)
{
    int[] array = new int[quantity];
    for (int index = 0; index < quantity; index++)
    {
        Console.Write($"Enter {index + 1} value: ");
        array[index] = int.Parse(Console.ReadLine());
    }
    return array;
}

int GetQntity(string text)
{
    Console.WriteLine(text);
    int quantity = int.Parse(Console.ReadLine());
    return quantity;
}

int quantity = GetQntity("How many numbers do you want to set?");
int[] array = GetArray(quantity);
int count = CheckPstv(array);
Console.Write(String.Join(", ", array));
Console.WriteLine($" -> {count}");