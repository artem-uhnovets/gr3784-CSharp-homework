// Напишите программу, которая принимает на вход 
// координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// MathF.Pow(x,y) метод возводит x в степень y, преобразует в тип float
// MathF.Sqrt (5.25) метод квадратного корня, преобразует в тип float

Console.Clear();
float Distance(float x1, float y1, float z1, float x2, float y2, float z2)
{
    float result = MathF.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
    Console.WriteLine($"Расстояние между точками равно {result}");
    return result;
}

float GetNum(string text)
{
    Console.WriteLine(text);
    float num = float.Parse(Console.ReadLine());
    return num;
}

float x1 = GetNum("Введите значение Х1 ");
float y1 = GetNum("Введите значение Y1 ");
float z1 = GetNum("Введите значение Z1 ");
float x2 = GetNum("Введите значение Х2 ");
float y2 = GetNum("Введите значение Y2 ");
float z2 = GetNum("Введите значение Z2 ");

Distance(x1, y1, z1, x2, y2, z2);