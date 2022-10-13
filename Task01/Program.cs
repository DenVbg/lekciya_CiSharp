//1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int souare = numberB * numberB;

if (numberA == souare)
{
 Console.WriteLine($"Число a = {numberA} явлется квадратом {souare} числа b = {numberB} ");   
}
else 
{
    Console.WriteLine($"Число a {numberA} НЕ явлется квадратом числа b = {numberB} ");   
}
