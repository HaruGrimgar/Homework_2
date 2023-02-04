/* 
Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число -> ");
string num_str = Console.ReadLine();
int num = Convert.ToInt32(num_str);
// Проверка на наличие третьего числа
if (num < 100)
{
    Console.WriteLine($"третьей цифры нет у числа {num}");
}
else
{
    int num_copy = num;
    int counter = 0;
    // Узнаём сколько цифр всего в числе

    while (num_copy > 0)
    {
        num_copy /= 10;
        counter += 1;
    }
// ToInt32(Math...) - для перевода результата метода 
int result = num / Convert.ToInt32(Math.Pow(10, counter - 3)) % 10;
Console.WriteLine(counter);
Console.Write($"Третья цифра числа {num} -> {result}");
}