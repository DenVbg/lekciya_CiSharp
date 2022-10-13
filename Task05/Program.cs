/* 5
Ввод числа
показываем числа в промежутке от -него до него
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number>0) {
    int count = -number;

    while (count<=number)
    {
        
        Console.Write($"{count}, ");
        count ++;
    }
}
else {

 Console.WriteLine("Введите число больше 0");   
}