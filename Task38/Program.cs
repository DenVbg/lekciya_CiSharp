// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Программа, покажет разницу между максимальным и минимальным элементом массива.");
Console.Write("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный и максимальный элемент массива. ");
Console.Write("Минимальное положительный число : ");
int min = Convert.ToInt32(Console.ReadLine());
while(min<0){
    Console.Write("Вы ввели не положительное число. Повторите ввод : ");
    min = Convert.ToInt32(Console.ReadLine());
    if (min<0) break;  
}
Console.Write("Максимальное трехзначное положительное число : ");
int max = Convert.ToInt32(Console.ReadLine());
while(max<0 && min<min){
    Console.WriteLine("Вы ввели не положительное число. Или число равно минимальному. Повторите ввод : ");
    max = Convert.ToInt32(Console.ReadLine());
    if (max<0 && min<min) break;  
}

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

int MarginMinMaxElements(int[] array)
{
    int marginElem = 0;
    int minElem = array[0];
    int maxElem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minElem<array[i]) minElem = array[i];   
        if (maxElem>array[i]) maxElem = array[i]; 
        marginElem = maxElem - minElem;
    }
    return marginElem;
}

int[] arr = CreateArrayRndInt(size, min, max);
Console.WriteLine("Наш массив");
PrintArray(arr);
int marginMinMaxElements = MarginMinMaxElements(arr);
Console.WriteLine($"Разницу между максимальным и минимальным элементом массива => {marginMinMaxElements} ");