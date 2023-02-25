// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] MultiplierArray(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayB.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            int elementArray = 0;
            for (int k = 0; k < arrayC.GetLength(0); k++)
            {
                elementArray += (arrayA[i, k] * arrayB[k, j]);
            }
            arrayC[i,j] = elementArray;
        }
    }
    return arrayC;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5}", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    string size = Console.ReadLine();
    while (int.TryParse(size, out _) == false || String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.WriteLine(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int sizeRowA = GetSize("Введите кол-во строк матрицы A ");
int sizeColumnA = GetSize("Введите кол-во столбцов матрицы A ");
int sizeRowB = sizeColumnA;
int sizeColumnB = GetSize("Введите кол-во столбцов матрицы B");
int[,] arrayA = GetArray(sizeRowA, sizeColumnA, 0, 10);
int[,] arrayB = GetArray(sizeRowB, sizeColumnB, 0, 10);
PrintArray(arrayA);
PrintArray(arrayB);
int[,] arrayC = MultiplierArray(arrayA, arrayB);
PrintArray(arrayC);