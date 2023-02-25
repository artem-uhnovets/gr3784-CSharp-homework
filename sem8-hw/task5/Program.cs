// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3:00}", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int x = 0;
    int y = 0;
    int moveX = 0;
    int moveY = 0;
    int count = 1;
    while (count <= rows * columns)
    {
        if (x + moveX >= 0 && x + moveX < rows && y + moveY >= 0 && y + moveY < columns && array[x + moveX, y + moveY] != 0)
        {
            if (moveX == 0 && moveY == 1) { moveX = 1; moveY = 0; }
            else if (moveX == 1 && moveY == 0) { moveX = 0; moveY = -1; }
            else if (moveX == 0 && moveY == -1) { moveX = -1; moveY = 0; }
            else if (moveX == -1 && moveY == 0) { moveX = 0; moveY = 1; }
        }
        if (x == 0 && y == (columns - 1)) { moveX = 1; moveY = 0; }
        else if (x == (rows - 1) && y == (columns - 1)) { moveX = 0; moveY = -1; }
        else if (x == (rows - 1) && y == 0) { moveX = -1; moveY = 0; }
        else if (array[x, y] == 1) { moveX = 0; moveY = 1; }
        x += moveX;
        y += moveY;
        array[x, y] = count++;
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

int sizeRow = GetSize("Введите кол-во строк матрицы ");
int sizeColumn = GetSize("Введите кол-во столбцов матрицы ");
int[,] array = GetArray(sizeRow, sizeColumn);
PrintArray(array);

// Кустарный способ только для 4х4
// int[,] GetArrayKustarniy(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     int count = 1;
//     for (int j = 0; j < columns; j++) array[0, j] = count++;
//     for (int i = 1; i < rows; i++) array[i, 3] = count++;
//     for (int j = 1; j < columns; j++) array[3, columns - 1 - j] = count++;
//     for (int i = 1; i < (rows - 1); i++) array[rows - 1 - i, 0] = count++;
//     for (int j = 1; j < (columns - 1); j++) array[1, j] = count++;
//     for (int j = 1; j < (columns - 1); j++) array[2, columns - 1 - j] = count++;
//     return array;
// }

// Первоначальный код
// if ((x == 0 && y == (array.GetLength(1) - 1)) || (x + moveX >= 0 && x + moveX < array.GetLength(0) && y + moveY >= 0 && y + moveY < array.GetLength(1) && array[x + moveX, y + moveY] != 0 && moveX == 0 && moveY == 1)) { moveX = 1; moveY = 0; }
// else if ((x == (array.GetLength(0) - 1) && y == (array.GetLength(1) - 1)) || (x + moveX >= 0 && x + moveX < array.GetLength(0) && y + moveY >= 0 && y + moveY < array.GetLength(1) && array[x + moveX, y + moveY] != 0 && moveX == 1 && moveY == 0)) { moveX = 0; moveY = -1; }
// else if ((x == (array.GetLength(0) - 1) && y == 0) || (x + moveX >= 0 && x + moveX < array.GetLength(0) && y + moveY >= 0 && y + moveY < array.GetLength(1) && array[x + moveX, y + moveY] != 0 && moveX == 0 && moveY == -1)) { moveX = -1; moveY = 0; }
// else if (x + moveX >= 0 && x + moveX < array.GetLength(0) && y + moveY >= 0 && y + moveY < array.GetLength(1) && array[x + moveX, y + moveY] != 0 && moveX == -1 && moveY == 0) { moveX = 0; moveY = 1; }
// else if (array[x, y] == 1) { moveX = 0; moveY = 1; }