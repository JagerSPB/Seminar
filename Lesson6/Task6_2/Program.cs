// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

double GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}
bool Check(double a, double b, double c)
{
  if (a >= b + c)
  {
    return false;
  }
  if (b >= a + c)
  {
    return false;
  }
  if (c >= a + b)
  {
    return false;
  }
  return true;
}

double a = GetNum("Введите первую сторону: ");
double b = GetNum("Введите вторую сторону: ");
double c = GetNum("Введите третью сторону: ");
if (Check(a, b, c))
{
  Console.WriteLine("Треугольник существует");
}
else
{
  Console.WriteLine("Треугольник не существует");
}