


Console.WriteLine("Введите число A");
int numA = int.Parse(Console.ReadLine());
if (numA % 7 == 0 && numA % 23 == 0)
{
  Console.WriteLine("да:");
}
else
{
  Console.WriteLine("Нет: " + numA);
}
