// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Комментарии после проверки
// Задачу 36 можно было решить короче:)
// Присвоить сразу счетчику значение 1 и идти по циклу с шагом 2,
// складывая с суммой значения элементов. 
// Тогда можно было не использовать условие внутри цикла. И сократить количество итераций вдвое.

// Запись типа number = number + value имеет короткую запись: number += value.
// Аналогично это работает для всех арифметических действий. Пользуйтесь на здоровье)

Console.Clear();

// int OddSumm(int[] array)
// {
//     int result = 0;
//     for (int index = 0; index < array.Length; index++)
//     {
//         if (index % 2 != 0)
//         {
//             result = result + array[index];
//         }
//     }
//     return result;
// }

int OddSumm(int[] array)
{
    int result = 0;
    for (int index = 1; index < array.Length; index=index+2)
    {
        result = result + array[index];
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != (array.Length - 1)) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(min, max + 1);
    }
    return arr;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}

int size = GetSize("Введите размер массива:");
int[] array = GetArray(size, -999, 999);
PrintArray(array);
int result = OddSumm(array);
Console.Write($" -> {result}");