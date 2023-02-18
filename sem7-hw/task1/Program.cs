// Задача 47.
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5   7    -2    -0,2
// 1    -3,3   8    -9,9
// 8     7,8  -7,1   9

Console.Clear();

double RandomDouble(double lower, double upper)
{
    var random = new Random();
    var result = random.NextDouble() * (upper - lower) + lower;
    return result;
}

void PrintArray(double[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + $"\t");
        }
        Console.WriteLine();
    }
}

double[,] GetArray(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(RandomDouble(min, max), 1);
        }
    }
    return array;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}

int sizeRow = GetSize("Введите кол-во строк ");
int sizeColumn = GetSize("Введите кол-во столбцов ");
double[,] array = GetArray(sizeRow, sizeColumn, -100 , 100);
PrintArray(array);