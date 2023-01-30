Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
int result = number2 * number2;

if (number1 == result)
  {
  Console.WriteLine("число 1 это квадрат числа 2");
  }
  else
  {
  Console.WriteLine("число 1 НЕ является квадратом числа 2");
  }
