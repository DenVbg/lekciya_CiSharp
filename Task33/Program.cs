﻿// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент : ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомый элемент массива : ");
int number = Convert.ToInt32(Console.ReadLine());

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

bool FindNumber(int[] array, int num)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) result = true;
        break;
    }
    return result;
}


int[] arr = CreateArrayRndInt(size, min, max);
Console.WriteLine("Наш массив");
PrintArray(arr);
bool findNumber = FindNumber(arr, number);
if (findNumber) Console.WriteLine($"Искомое число {number} в массиве найдено");
else Console.WriteLine($"Искомое число {number} в массиве не найдено");

