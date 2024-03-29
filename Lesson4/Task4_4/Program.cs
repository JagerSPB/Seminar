﻿// /*Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// */
/* --------- Вывод массива ---------- */
void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write(arr[i] + " ");
  }
  Console.WriteLine();
}
/* ---------------------------------- */

/* ----- Заполнение массива рандомными цифрами ----- */
void FillArrayWithRandom(int[] array, int from, int to)
{
  // to == 1; Random -> 0, 0;
  int random = 0;
  for (int i = 0; i < array.Length; i++)
  {
    random = new Random().Next(from, (to + 1));
    array[i] = random;
  }
}
/* ------------------------------------------------ */

/* ------- Создание массива с размером - 10 */
int[] numArray = new int[8];
/* ---------------------------------------- */

/* --------- Программа -------------- */
FillArrayWithRandom(numArray, 0, 1);

PrintArray(numArray);
/* ----------------------------------- */