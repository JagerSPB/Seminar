// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] GenerateMatrix(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = new Random().Next(lowerBound, upperBound);
    }
  return result;
}

void ChangeMatrix(int[,] matrix)
{
  int row = matrix.GetLength(0);
  int col = matrix.GetLength(1);
  int[,] matrix2 = new int[col, row];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      matrix2[j, i] = matrix[i, j];
    }
  }
  Console.WriteLine("==============================");
  ShowMatrix(matrix2);
}

void ShowMatrix(int[,] matrix)
{
  Console.WriteLine();
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write(String.Format("{0,3} ", matrix[i, j]));
    }
    Console.WriteLine();
  }
}

// Генерируем массив
int[,] matrix = GenerateMatrix(5, 4, 1, 9);

// Выводим массив
ShowMatrix(matrix);
ChangeMatrix(matrix);