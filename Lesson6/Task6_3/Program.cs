// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

string TranslateNum(int number, int numberBase)
{
  string res = "";
  
  while (number > 0)
  {
    res = (number % numberBase).ToString() + res;
    number /= numberBase;
  }
  return res;
}

int number = GetNum("Введите число: ");
Console.WriteLine($"{number} -> {TranslateNum(number, 2)}");