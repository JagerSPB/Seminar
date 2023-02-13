﻿// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int RecSum(int n)
{
  if (n < 10) return n;

  return n % 10 + RecSum(n / 10);
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение числа

int num = GetNum("Введите число: ");
Console.WriteLine(RecSum(num));