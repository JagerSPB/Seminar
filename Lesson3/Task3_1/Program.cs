// Задача №17. Напишите программу, которая принимает на вход координаты точки 
// (X и Y),причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой 
// находится эта точка.

void CheckQuarter(int x, int y)
{
  if (x > 0 & y > 0)
  {
    Console.WriteLine(1);
  }
  if (x < 0 & y > 0)
  {
    Console.WriteLine(2);
  }
  if (x < 0 & y < 0)
  {
    Console.WriteLine(3);
  }
  if (x > 0 & y < 0)
  {
    Console.WriteLine(4);
  }
}

int GetNum(string text)
{
  Console.WriteLine(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// ввод данных от пользователя x, y
int x = GetNum("введите значение X");
int y = GetNum("введите значение Y");
Console.Write("Quarter is: ");

// определить четверть
CheckQuarter(x, y);