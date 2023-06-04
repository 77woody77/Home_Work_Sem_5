// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


int[] array = Creatingrandomarray(25, 100, 1000);
Console.WriteLine(String.Join(", ", array));



int[] Creatingrandomarray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int Evennumbers(int[] array)
{
   int even = 0;
   for(int i =0; i < array.Length; i++)
   {
     even += array[i] % 2 == 0  ? 1 : 0;
   }
   return even;
}   
Console.WriteLine($"Количество четных чисел массива : {Evennumbers(array)}");
