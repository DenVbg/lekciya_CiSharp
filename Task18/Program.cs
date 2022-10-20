// Задача 18: Напишите программу, которая 
// Вход по заданному номеру четверти, 
// Выход показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти плоскости:");
int quarter = Convert.ToInt32(Console.ReadLine());

string Quarter(int quarter_xy)
{
    if (quarter_xy==1) return "x > 0 && y > 0";
    if (quarter_xy==2) return "x < 0 && y > 0";
    if (quarter_xy==3) return "x < 0 && y < 0";
    if (quarter_xy==4) return "x > 0 && y < 0";
    return "введен некоректный номер четверти";
}

string xy = Quarter(quarter);
Console.Write($"Диапазон координат для четверти {quarter}: ");
Console.WriteLine(xy);
