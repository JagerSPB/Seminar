// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//AB = √(xb - xa)2 + (yb - ya)2

void GetDist(double x1, double y1, double x2, double y2)
{
  double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
  Console.WriteLine(dist);
}

double GetNum(string text)
{
  Console.WriteLine(text);
  double num = double.Parse(Console.ReadLine());
  return num;
}
// ввод данных от пользователя x, y
double x1 = GetNum("введите значение X1");
double y1 = GetNum("введите значение Y1");
double x2 = GetNum("введите значение X2");
double y2 = GetNum("введите значение Y2");

Console.Write("Dist is: ");

// определить расстояние
GetDist(x1, y1, x2, y2);