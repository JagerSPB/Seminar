// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).


void CheckXY(int quarter)
{
  if (quarter == 1) Console.WriteLine("x > 0 y > 0");
  if (quarter == 2) Console.WriteLine("x < 0 y > 0");
  if (quarter == 3) Console.WriteLine("x < 0 y < 0");
  if (quarter == 4) Console.WriteLine("x > 0 y < 0");
}

int GetQuarter(string text)
{
  Console.WriteLine(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// ввод данных от пользователя
int quarter = GetQuarter("введите значение от 1 до 4 ");

Console.Write("Диапозон: ");

// определить четверть
CheckXY(quarter);