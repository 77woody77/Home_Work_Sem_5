﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = Creatingrandomarray(10, 0, 50);
Console.WriteLine(String.Join("; ", array));



int[] Creatingrandomarray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}


int Sumelements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
     {
       sum += array[i]; 
     }
    return sum;
}
Console.WriteLine($"Сумма чисел стоящих на нечетных позициях : {Sumelements(array)}");