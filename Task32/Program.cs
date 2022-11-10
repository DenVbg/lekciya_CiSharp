// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void ArrayInvers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *=-1;
    }
}

int[] arr = CreateArrayRndInt(size, min, max);
PrintArray(arr);
ArrayInvers(arr);
PrintArray(arr);

