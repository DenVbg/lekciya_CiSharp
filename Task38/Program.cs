// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Программа, задаст массив вещественных чисел и покажет разницу между максимальным и минимальным элементом массива.");
Console.Write("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный и максимальный элемент массива. ");
Console.Write("Минимальное число : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное число : ");
int max = Convert.ToInt32(Console.ReadLine());
while (min >= max)
{
    Console.WriteLine("Введенный максимальный элемент массива меньше либо равен минимальному. Повторите ввод");
    Console.Write("Максимальное число : ");
    max = Convert.ToInt32(Console.ReadLine());
    if (max > min) break;
}

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write("; ");
    }
    Console.WriteLine("]");
}

double MarginMinMaxElements(double[] array)
{
    double marginElem = 0;
    double minElem = array[0];
    double maxElem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minElem > array[i]) minElem = array[i];
        if (maxElem < array[i]) maxElem = array[i];
        marginElem = maxElem - minElem;
    }
    return Math.Round(marginElem,1);
}

//double[] arr = {3.5, 7.1, 22.9, 2.3, 78.5};
double[] arr = CreateArrayRndInt(size, min, max);
Console.WriteLine("Наш массив");
PrintArray(arr);
double marginMinMaxElements = MarginMinMaxElements(arr);
Console.WriteLine($"Разницу между максимальным и минимальным элементом массива => {marginMinMaxElements} ");