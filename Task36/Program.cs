// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sizeDigit = 8; // количество элементов массива

int[] SizeArray(int size)
{
    int[] array = new int[size]; //
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] sizeArray = SizeArray(sizeDigit);
Console.WriteLine("Вывод массива из 8 элементов заполненный псевдослучайными числами : ");
PrintArray(sizeArray);