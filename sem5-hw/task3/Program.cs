// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Комментарии после проверки
// Целые числа, конечно, тоже вещественные, но стоило все же создать массив с числами типа double или float.

// Вы присвоили переменным min и max значение нулевого элемента.
// Очевидно, что значение нулевого элемента будет равны значениям min и max.
// Так, зачем тогда сравнивать их в цикле? Можно сразу начать цикл с элемента с индексом 1.

// В цикле поиска минимального и максимального значений второй блок лучше указать else if.
// Ведь если переменной min присваивается значение элемента, то уже max точно оно не будет присвоено.
// Так что, в пределах одной итерации можно будет пропустить else if.

Console.Clear();

int SummMinMax(int[] array)
{
    int result = 0;
    int min = array[0];
    int max = array[0];
    for (int index = 1; index < array.Length; index++)
    {
        if (array[index] < min) min = array[index];
        else if (array[index] > max) max = array[index];
    }
    result = max - min;
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
int[] array = GetArray(size, 0, 100);
PrintArray(array);
int result = SummMinMax(array);
Console.Write($" -> {result}");