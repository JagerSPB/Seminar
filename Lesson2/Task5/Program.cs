

Console.WriteLine("Введите число A");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int numB = int.Parse(Console.ReadLine());

int result = numA * numA;
int result1 = numB * numB;
if (result == numB || result1 == numA)
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");
}