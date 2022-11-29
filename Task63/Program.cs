// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите натуральное число N:");
// int number = Convert.ToInt32(Console.ReadLine());

// void NaturalNumbers(int num)
// {    
//     if (num==0) return;
//     NaturalNumbers(num-1);
//     Console.Write($"{num} "); 
// }

// NaturalNumbers(number);

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num) //5
{
// вариант 1    
    // if (num == 0) return;
    //  // Console.Write($"{num} "); // 5 4 3 2 1 
    // NaturalNumbers(num - 1);
    // Console.Write($"{num} "); // 1 2 3 4 5 

// вариант 2
    if (num > 0) 
    {
        // Console.Write($"{num} "); // 5 4 3 2 1 
        NaturalNumbers(num - 1);
        Console.Write($"{num} "); // 1 2 3 4 5
    }
}

NaturalNumbers(number);

