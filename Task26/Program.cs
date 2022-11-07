// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int CountDigit(int number)
{
    number = Math.Abs(number);
    // int count = default;
    // while (number>0) 
    //{     
        //number /= 10;
        //count++;
    //}
    //return count>0 ? count : 1;

    int i = 0;
    for (i=0; number>0; i++) 
    {
        //number = number / 10;
        number /= 10;
     }
    return i>0 ? i : 1;
}

int countDigit = CountDigit(num);
Console.WriteLine($"Количество цифр в числе {num} => {countDigit}");
