// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6); B (2,1), -> 15.09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату x для точки А: ");
int xA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y для точки А: ");
int yA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z для точки A: ");
int zA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x для точки B: ");
int xB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y для точки B: ");
int yB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z для точки B: ");
int zB = int.Parse(Console.ReadLine());

double distans = 0;
// √((xb - xa)2 + (yb - ya)2)
distans = Math.Sqrt(Math.Pow(xA-xB,2) + Math.Pow(yA-yB,2) + Math.Pow(zA-zB,2));

Console.WriteLine(Math.Round(distans, 3));


