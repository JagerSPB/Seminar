// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения 
// которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int GetArr1099(int[] array)
{
  int size = array.Length;
  int result = 0;
  for (int i = 0; i < size; i++)
  {
    if (array[i] / 100 == 0 && array[i] >= 10)
    {
      result = result + 1;
    }
  }
  return result;
}

int[] GetArray(int size, int start, int finish)
{
  int[] emptyArray = new int[size];
  for (int index = 0; index < size; index++)
  {
    emptyArray[index] = new Random().Next(start, finish + 1);
  }
  return emptyArray;
}

// Генерируем массив
int[] array = GetArray(123, 0, 1000);
Console.Write(String.Join(", ", array));

int arr = GetArr1099(array);
Console.WriteLine(String.Join(" ", " ->", arr));