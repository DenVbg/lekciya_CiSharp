// 0 Напишите программу которая
// 1. На вход принимает число
// 2. выдает его квадрат (число умноженое на само себя)

// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// string str = Console.ReadLine();
// int number = Convert.ToInt32(str);

int square  = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");