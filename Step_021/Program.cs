// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Coordinate("x", "A");
int x2 = Coordinate("x", "B");
int y1 = Coordinate("y", "A");
int y2 = Coordinate("y", "B");
int h1 = Coordinate("h", "A");
int h2 = Coordinate("h", "B");


int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2, double h1, double h2){                 // double 
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((h2-h1), 2));            // Math.Sqrt
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, h1, h2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");