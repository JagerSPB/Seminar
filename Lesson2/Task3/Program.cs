

Console.WriteLine("Введите число A");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int numB = int.Parse(Console.ReadLine());

int result = (numB % numA);

if (result == 0)
{
 Console.WriteLine("число кратно");
}
else
{
  Console.WriteLine("число не кратно");
}