// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Комментарии после проверки ДЗ
// Задача 41
// Тут можно было в одном цикле и получать числа от пользователя и считать положительные числа. Даже можно было их не записывать в массив, в условиях же этого не требовалось:)

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