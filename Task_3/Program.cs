/* 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите цифру дня недели -> ");
string num_str = Console.ReadLine();
int num = Convert.ToInt32(num_str);

if (num <= 5)
{
    Console.WriteLine($"{num} -> не выходной");
}
else
{
    Console.WriteLine($"{num} -> выходной");
}