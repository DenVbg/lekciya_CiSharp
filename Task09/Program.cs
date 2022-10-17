// 1. Вход случайное число от 10 до 99
// 2. Вывод показать наибольшая цифра числа
//  78 -> 8
//  12 -> 2
//  85 -> 8


int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число от 10 до 99: {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
// 1.Вариант (условный оператор)
// if (firstDigit>secondDigit) Console.WriteLine($"наибольшая 1 цифра числа {firstDigit}"); 
// else if(firstDigit==secondDigit) Console.WriteLine($"1 цифра числа и 2 цифра числа равны {secondDigit}");  
// else Console.WriteLine($"наибольшая 2 цифра числа {secondDigit}");  

// 2.Вариант (тернарный оператор)
// int maxDigit = firstDigit>secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"наибольшая цифра числа {maxDigit} ");  

// 3.Вариант
// Console.Write($"наибольшая цифра числа: ");  
// Console.WriteLine(firstDigit>secondDigit ? firstDigit: secondDigit);

// 4.Вариант используя методы
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;    
    return firstDigit>secondDigit ? firstDigit: secondDigit;
}

int maxDigit = MaxDigit(number); 
Console.WriteLine($"наибольшая цифра числа {maxDigit} ");  