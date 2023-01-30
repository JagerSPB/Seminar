// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void GetN(int numN)
{
  int i = 1;
  while (i < numN)
  {
    Console.Write(Math.Pow(i, 2) + ", ");
    i++;
  }
  Console.Write(Math.Pow(numN, 2) + Environment.NewLine);
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// ввод данных от пользователя
int numN = GetNum("введите значение: ");
Console.Write("-> ");

//вывести таблицу квадратов
GetN(numN);