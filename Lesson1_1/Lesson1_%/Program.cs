/*Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = (number % 10);
Console.Write("-> ");
Console.WriteLine(result);
