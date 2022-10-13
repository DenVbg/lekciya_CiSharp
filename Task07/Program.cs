/* 7 НА вход 3-х значное число
на выходе последние цифра этого числа
456 - 6
782 - 2 
918 - 8
*/
Console.WriteLine("Введите 3-х значное число");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000) {
    int lastDigit = number % 10; // 456/10=45.6
    Console.WriteLine($"последняя цифра числа {lastDigit}");
}
else {
    Console.WriteLine("Вы ввели не 3-х значное число");
}
