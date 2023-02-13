// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию 
// о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

int[,] GenerateMatrix(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] result = new int[rows, columns];
  Random random = new Random();
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = random.Next(lowerBound, upperBound);
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
      Console.Write(String.Format("{0,3} ", matrix[i, j]));
    }
    Console.WriteLine();
  }
}

// Получение размерности от пользователя: m,n
int m = GetNum("Введите кол-во строк: ");
int n = GetNum("Введите кол-во столбцов: ");

// Генерируем массив
int[,] matrix = GenerateMatrix(m, n, 0, 10);

// Выводим результат
ShowMatrix(matrix);

//CheckNum


int[] CheckNum(int[,] matrix)
{
  int row = matrix.GetLength(0);
  int col = matrix.GetLength(1);
  int[] arrayNew = new int[10];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      arrayNew[matrix[i, j]] += 1;
    }
  }
  return arrayNew;
}

int[] arrayChast = CheckNum(matrix);

for (int i = 0; i < arrayChast.Length; i++)
  if (arrayChast[i] > 0)
    Console.WriteLine($"{i} количество {arrayChast[i]}");