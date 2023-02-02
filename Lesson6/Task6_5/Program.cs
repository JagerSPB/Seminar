//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size, int lowerBound, int upperBound)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(lowerBound, upperBound);
  }
  return array;
}
int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}
int[] CopyArrayByElement(int[] array)
{
  int[] copiedArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    copiedArray[i] = array[i];
  }
  return copiedArray;
}

int size = GetNum("Введите размер массива: ");
int[] array1 = CreateRandomArray(size, 1, 10);
int[] array2 = CopyArrayByElement(array1);
Console.WriteLine(String.Join("\t", array1));
Console.WriteLine(String.Join("\t", array2));