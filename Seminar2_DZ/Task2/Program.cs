﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string nText = Convert.ToString(n);
if (nText.Length > 2){
  Console.WriteLine("Третья цифра: " + nText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}