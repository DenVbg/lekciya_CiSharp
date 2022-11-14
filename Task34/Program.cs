// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Программа, покажет количество чётных чисел в массиве.");
Console.WriteLine("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный и максимальный элемент массива. ");
Console.WriteLine("Минимальное трехзначное положительный число : ");
int min = Convert.ToInt32(Console.ReadLine());
while(min<100 && min<1000){
    Console.WriteLine("Вы ввели не трехзначное положительное число. Повторите ввод : ");
    min = Convert.ToInt32(Console.ReadLine());
    if (min>99 && min<1000) break;  
}
Console.WriteLine("Максимальное трехзначное положительное число : ");
int max = Convert.ToInt32(Console.ReadLine());
while(max<100 && max<1000){
    Console.WriteLine("Вы ввели не трехзначное положительное число. Повторите ввод : ");
    max = Convert.ToInt32(Console.ReadLine());
    if (max>99 && max<1000) break;  
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

int CountEvenNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) result ++;        
    }
    return result;
}

int[] arr = CreateArrayRndInt(size, min, max);
Console.WriteLine("Наш массив");
PrintArray(arr);
int countEvenNumber = CountEvenNumber(arr);
Console.WriteLine($"Количество чётных чисел в массиве => {countEvenNumber} ");