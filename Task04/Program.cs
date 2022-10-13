//4. Напишите программу, которая 
// вход принимает три числа 
// выдает, какое число большее
//2,3,7 -> max=7
//44,5,78 -> max=78
//22,3,9 -> max=22


Console.WriteLine("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max)
{
    max = numberB;  
}
if (numberC > max)
{
    max = numberC;  
}

Console.WriteLine($"Максимальным из введенных числел {numberA}, {numberB}, {numberC}. является число - {max}");
