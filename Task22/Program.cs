// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1,4,9,16,25

// Console.WriteLine("Введите данные:");
// int n = Convert.ToInt32(Console.ReadLine());
// int count=1;
// while (count <=n)
// {
//     int quad = count*count; 
//     Console.WriteLine($"{count}  ->  {quad}"); 
//     count++;
// }

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void SquareTable(int num)
// {
//     if (num > 0)
//     {
//         for (int i = 1; i <= num; i++)
//         {
//             Console.WriteLine($"|{i,4} | {i * i,4}|");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Введите значение больше 0");
//     }
// }

// SquareTable(n);


void ToQuad(int n1) 
{
    int count = 1;
    while (count<=n1)
    {
        int quad = count*count; 
        Console.WriteLine($"|{count,4} | {quad,4}|"); 
        count++;
    }
}

Console.WriteLine("Введите данные:");
int n = Convert.ToInt32(Console.ReadLine());
ToQuad(n);






