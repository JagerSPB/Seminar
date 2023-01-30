// Задача 24: Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSum(int num)
{

  int result = 0;
  for (int i = 1; i <= num; i++)
  {
    result = result + i;
  }
  return result;
}

int PromptNumber(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

// ввод данных пользователя
int number = PromptNumber("введите число: ");

//в цикле суммируем все числа
Console.WriteLine(number + " -> " + GetSum(number));