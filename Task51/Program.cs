// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        } 
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
            else Console.Write($"{matrix[i,j],5}");
        }
        Console.WriteLine("]");
    }

}

int SumElemDiagMatrix(int[,] matrix) 
{
    int sum = 0;

    int minLenght = matrix.GetLength(0);
    if (matrix.GetLength(1) < matrix.GetLength(0)) minLenght = matrix.GetLength(1);
    for (int i = 0; i < minLenght; i++) 
    {
        sum += matrix[i,i];
    }

    // for (int i = 0; i < matrix.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j++) 
    //     {
    //         if (i==j) sum += matrix[i,j];
    //     }
    // }

    return sum;
}

int[,]newMatrix = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(newMatrix);
int sumElemDiagMatrix = SumElemDiagMatrix(newMatrix);
Console.WriteLine ("");
Console.WriteLine ($"Сумма элементов диагонали равна: {sumElemDiagMatrix}");