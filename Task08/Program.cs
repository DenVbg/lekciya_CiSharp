// Напишите программу, которая
// вход число (N),
// выход все четные числа от 1 до N
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (N<=0) {
    Console.Write("Вы ввели число меньше либо равное \"0\".");
}
else {
    Console.Write("Четные числа от 1 до N: ");
    while (count <=N) { 
        if (count%2<1) {
            Console.Write($"{count} ");
        }
        count++;
    }
}


