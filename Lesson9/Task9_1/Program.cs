// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void Rec(int n)
{
  if (n == 0) return;
  Rec(n - 1);
  Console.Write($"{n} ");
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение числа

int num = GetNum("Введите число: ");
Rec(num);