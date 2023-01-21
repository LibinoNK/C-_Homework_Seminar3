/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double[] coordsA = new double[3];
double[] coordsB = new double[3];
System.Console.WriteLine("Введите координаты X точки А: ");
coordsA [0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y точки A: ");
coordsA [1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Z точки A: ");
coordsA [2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты X точки B: ");
coordsB [0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y точки B: ");
coordsB [1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Z точки A: ");
coordsB [2] = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(coordsA[0] - coordsB[0], 2) + Math.Pow(coordsA[1] - coordsB[1], 2) + Math.Pow(coordsA[2] - coordsB[2], 2));
System.Console.WriteLine($"Расстояние расстояние 2 введенными точками в 3D пространстве равно: {Math.Round(S, 2)}");