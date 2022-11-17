// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int BinaryNum(int number)
// {
//     string str = "";
//     while (number > 0)
//     {
//         string temp = Convert.ToString(number % 2);
//         str = temp + str;
//         number = number / 2;
//     }
//     int bin = Convert.ToInt32(str);
//     return bin;
// }

// int binaryNum = BinaryNum(num);
// Console.WriteLine($"Число {num} в бинаром виде => {binaryNum}");

// Второй вариант


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int num)
{
    int result = 0;
    while (num > 0 && num > 9)
    {
        int dig1 = num % 2;
        result += dig1;
        result *= 10;
        num /= 2;
    }
    return result;
// int ConvertToBin(int num10)
// {
//     int num2 = default;

//     while (num10 > 0)
//     {
//         num2 += num10 % 2;
//         num2 *= 10;
//         num10 /= 2;
//         ConvertToBin(num10);
//     }

//     return num2;
// }


}

int RevertNumber(int par)
{
    int result = 0;
    while (par > 9)
    {
        result += par % 10;
        result *= 10;
        par /= 10;
    }
    result += par % 10;
    return result;
}

Console.WriteLine(RevertNumber(ConvertToBin(number)));

// Другое решение
// int d10 = 1;
//             int result = 0;
//             int number = 46;
//             while (number != 0)
//             {
//                 result = result + number % 2 * d10;
//                 number = number / 2;
//                 d10 = d10 * 10;
//             }
//             Console.WriteLine($"{result}");
