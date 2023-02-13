//  Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.
// 

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

  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    int temp = matrix[0, j];
    matrix[0,j]=matrix[matrix.GetLength(0) - 1, j];
    matrix[matrix.GetLength(0) - 1, j] = temp;
  }
  Console.WriteLine("==============================");
  ShowMatrix(matrix);
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
int[,] matrix = GenerateMatrix(3, 4, 1, 9);

// Выводим массив
ShowMatrix(matrix);
ChangeMatrix(matrix);