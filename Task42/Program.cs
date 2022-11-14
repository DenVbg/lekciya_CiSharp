// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int BinaryNum(int number) 
{
    string str ="";
    while (number>0) {
       string temp = Convert.ToString(number % 2);
        str = temp+str;
        number = number / 2;
    }
    int bin = Convert.ToInt32(str);
    return bin;
}

int binaryNum = BinaryNum(num);
Console.WriteLine($"Число {num} в бинаром виде => {binaryNum}");

