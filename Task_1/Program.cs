/* 
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 
 */

Console.Write("Введите трёхзначное число -> ");
string num_str = Console.ReadLine();
int num = Convert.ToInt32(num_str);

int result = num % 100 / 10;

Console.Write($"Вторая цифра числа {num} -> {result}");

