// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

int[] NewArray(int[] array)
{      
    int newSize = array.Length/2;
    if (array.Length%2==1) newSize++;
    int[] newArr = new int[newSize];
    for (int i = 0; i < array.Length/2; i++)
    {
        newArr[i] = array[i] * array[array.Length-1-i];        
    }
    if (array.Length%2==1) newArr[newSize-1] = array[newSize-1]; 
    return newArr;
}

int[] arr = CreateArrayRndInt(size, min, max);
Console.WriteLine("Исходный массив");
PrintArray(arr);

int[] newArray = NewArray(arr);
Console.WriteLine("Полученный массив");
PrintArray(newArray);