// 1. вход случайное трехзначное число
// 2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// 1.Вариант
//int number = new Random().Next(100,1000);
//Console.WriteLine($"Случайное число от 100 до 999: {number}");

// int firstDigit = number / 100;
// // Console.WriteLine($"1 цифра: {firstDigit}");
// int thirdDigit = number % 10;
// // Console.WriteLine($"3 цифра: {thirdDigit}");

// int result = firstDigit*10 + thirdDigit;
// Console.WriteLine($"вывод: {result}");

// 2.Вариант
int DelSecondDigit(int num) //num=number
{
    int firstDigit = num / 100;
    //Console.WriteLine($"1 цифра: {firstDigit}");
    int thirdDigit = num % 10;
    //Console.WriteLine($"3 цифра: {thirdDigit}");
    int result = firstDigit*10 + thirdDigit;
    return result;
}

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число от 100 до 999: {number}");
int result = DelSecondDigit(number);

Console.WriteLine($"вывод: {result}");

