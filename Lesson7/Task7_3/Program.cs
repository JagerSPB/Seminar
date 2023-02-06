// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  for (int i = 1; i < rows; i += 2)
  {
    for (int j = 1; j < columns; j += 2)
    {
      matrix[i, j] = matrix[i, j] * matrix[i, j];
    }
    Console.WriteLine();
  }
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

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение размерности от пользователя: m,n
int m = GetNum("Введите кол-во строк: ");
int n = GetNum("Введите кол-во столбцов: ");

// Генерируем массив
int[,] matrix = GenerateMatrix(m, n, 1, 9);

// обробатываем массив
//ChangeMatrix(matrix);


// Выводим исходный массив
ShowMatrix(matrix);
// обробатываем массив
ChangeMatrix(matrix);
// Выводим результат
ShowMatrix(matrix);