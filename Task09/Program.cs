// 1. Вход случайное число от 10 до 99
// 2. Вывод показать наибольшая цифра числа
//  78 -> 8
//  12 -> 2
//  85 -> 8


int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число от 10 до 99: {number}");
int num1 = number / 10;
int num2 = number % 10;
if (num1>num2) Console.WriteLine($"max = {num1}, min = {num2} "); 
else Console.WriteLine($"max = {num2}, min = {num1} ");  