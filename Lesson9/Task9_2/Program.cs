// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Rec(int m, int n)
{
  if (n < m) return;
  Rec(m, n - 1);
  Console.Write($"{n} ");
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение 
int numM = GetNum("Введите число m: ");
int numN = GetNum("Введите число n: ");

Rec(numM, numN);