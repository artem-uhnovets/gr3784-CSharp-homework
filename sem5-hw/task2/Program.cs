// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int OddSumm(int[] array)
{
    int result = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (index % 2 != 0)
        {
            result = result + array[index];
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == (array.Length - 1)) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
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