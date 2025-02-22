﻿/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
int result = 0;
InputArray(numbers);

for (int n = 0; n < numbers.Length; n++)
{
    if (n % 2 != 0) result = result + numbers[n];
        count++;
}
Console.WriteLine($"Вывод массива: [{string.Join(", ", numbers)}]");
Console.WriteLine($"Сумма элементов,стоящих на нечетных позициях: {result}");