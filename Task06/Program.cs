// 6 Напишите программу которая
// 1. На вход принимает число
// 2. выдает является ли число четным (делится ли оно на 2 без остатка)

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Является ли число {number} четным? ");    
int result  = number%2;
if (result == 0) {
    Console.Write("ДА, является.");
}
else Console.Write("Нет, не является.");    
