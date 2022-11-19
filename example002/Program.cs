// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите x координату точки A ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y координату точки A ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z координату точки A ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите x координату точки B ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y координату точки B ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z координату точки B ");
int bz = Convert.ToInt32(Console.ReadLine());


double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res1 = (x2 - x1) * (x2 - x1);
    double res2 = (y2 - y1) * (y2 - y1);
    double res3 = (z2 - z1) * (z2 - z1);
    double result = res1 + res2 + res3;
    return Math.Sqrt(result);
}

double distance = Distance(ax, ay, az, bx, by, bz);

Console.Write($"A({ax},{ay},{az}); B({bx},{by},{bz}) -> ");
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));