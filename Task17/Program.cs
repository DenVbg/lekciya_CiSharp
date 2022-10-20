// напишите программу 
// вход координаты точки  (Х Y)
// условие  X ≠ 0 и Y ≠ 0 
// выдает номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите координаты точки:");
Console.Write("Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0
? $"Указанные координаты соответствуют четверти -> {quarter}"
: "Введены некорректные координаты";
Console.WriteLine(result);
