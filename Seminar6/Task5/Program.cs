﻿//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = string.Empty;
while (n > 0)
{
result = Convert.ToString(n % 2) + result;
n /= 2; // n = n / 2;
}
Console.WriteLine(result);