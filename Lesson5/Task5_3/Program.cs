// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void ConvertArray(int[] arr)
{
  for (int index = 0; index < arr.Length; index++)
  {
    arr[index] = arr[index] * -1;
  }
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
int[] array = GetArray(5, -9, 9);
Console.WriteLine(String.Join(", ", array));

// сумма отрицательных чисел
ConvertArray(array);
Console.WriteLine(String.Join(", ", array));