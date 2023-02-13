
string Recursia(int start, int finish)
{
  if (start == finish) return start.ToString();
  return (start + ", " + Recursia(start + 1, finish));

}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение числа

int numM = GetNum("Введите число M: ");
int numN = GetNum("Введите число N: ");
Console.WriteLine(Recursia(numM, numN));
