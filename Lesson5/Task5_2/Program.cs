// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int GetSumPlusOrMinus(int[] arr, bool positive)
{
  int result = 0;
  int size = arr.Length;
  for (int index = 0; index < size; index++)
  {
    if (arr[index] > 0 && positive == true)
    {
      result = result + arr[index];
    }
    if (arr[index] < 0 && positive == false)
    {
      result = result + arr[index];
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

// генерируем массив
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

// сумма положительных чисел
int sumPlusNum = GetSumPlusOrMinus(array, true);

// сумма отрицательных чисел
int sumMinusNum = GetSumPlusOrMinus(array, false);
Console.WriteLine($"сумма положительных чисел = {sumPlusNum}, сумма отрицательных чисел = {sumMinusNum} ");