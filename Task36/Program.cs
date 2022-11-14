// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Найти сумму элементов, стоящих на нечётных позициях в массиве.");
Console.Write0("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumElements(int[] array)
{
    int sumElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2!=0) sumElem +=array[i];        
    }
    return sumElem;
}

int[] arr = CreateArrayRndInt(size, min, max);
Console.WriteLine("Наш массив");
PrintArray(arr);
int sumElements = SumElements(arr);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях в массиве => {sumElements} ");