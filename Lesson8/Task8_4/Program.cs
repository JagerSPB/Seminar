// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая 
// удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[,] GetMinus(int[,] matrix)
{
  int sizeM = matrix.GetLength(0);
  int sizeN = matrix.GetLength(1);
  int min = matrix[0, 0];
  int minX = 0;
  int minY = 0;

  for (int i = 0; i < sizeM; i++)
  {
    for (int j = 0; j < sizeN; j++)
    {
      if (matrix[i, j] < min)
      {
        min = matrix[i, j];
        minX = j;
        minY = i;
      }
    }
  }
  int[,] arrayNew = new int[sizeM - 1, sizeN - 1];

  int ii = 0, jj = 0;
  for (int i = 0; i < sizeM; i++)
  {
    if (i == minY)
    {
      continue;
    }
    jj = 0;
    for (int j = 0; j < sizeN; j++)
    {
      if (j == minX)
      {
        continue;
      }
      arrayNew[ii, jj] = matrix[i, j];
      jj++;
    }
    ii++;
  }
  return arrayNew;
}

// Генерируем массив
int[,] matrix = GenerateMatrix(5, 4, 1, 9);

// Выводим массив
ShowMatrix(matrix);
//ChangeMatrix(matrix);

Console.WriteLine();

int[,] arrayMin = GetMinus(matrix);

ShowMatrix(arrayMin);