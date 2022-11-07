// Задача 24: Напишите программу, которая
// 1.принимает на вход число (А) 
// 2.и выдаёт сумму чисел
// от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    // int sum=0;        
    // count=0;
    // while (count <=number) { 

    //     sum+=count;
    // }
    // count++;

    int sum=default;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;    
}


int sumNumbers = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} => {sumNumbers}");
