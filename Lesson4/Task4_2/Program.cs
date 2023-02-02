// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int GetNubersCount(int num)
{
  int count = 1;
  for (int i = num; i >= 10; i = i / 10)
  {
    count++;
  }
  return count;
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

Console.WriteLine(number + "->" + GetNubersCount(number));
