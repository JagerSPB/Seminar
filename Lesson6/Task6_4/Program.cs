// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int number = GetNum("Введите N: ");
int fib1 = 0;
int fib2 = 1;
int fib3 = fib1 + fib2;
Console.Write($"Первые {number} Фибоначчи: {fib1} {fib2} ");

for (int i = 2; i < number; i++)
{
  Console.Write(fib3 + " ");
  fib1 = fib2;
  fib2 = fib3;
  fib3 = fib1 + fib2;
}