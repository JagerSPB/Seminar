// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

int[,] GenerateMatrix(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = new Random().Next(lowerBound, upperBound + 1);
    }
  return result;
}

void ShowMatrix(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

// Получение размерности от пользователя: m,n
int m = GetNum("Введите кол-во строк: ");
int n = GetNum("Введите кол-во столбцов: ");

// Генерируем массив
int[,] matrix = GenerateMatrix(m, n, -100, 100);

// Выводим результат
ShowMatrix(matrix);