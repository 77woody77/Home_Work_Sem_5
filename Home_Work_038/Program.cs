// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = Creatingrandomarray(10, 0, 50);
Console.WriteLine(String.Join(" || ", array));
Console.WriteLine($"Разница: {FindMax(array) - FindMin(array)}"); 

double[] Creatingrandomarray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble()*100, 2);

    }
    return result;
}


double FindMax(double[] arr)
 {
    double Max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
    if (Max < arr[i])
        Max = arr[i];
    }
        return Max;
 }


 double FindMin(double[] arr)
 {
    double Min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
    if (Min > arr[i])
        Min = arr[i];
    }
        return Min;
 }