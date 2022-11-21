// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Write("Введите количество строк двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива : ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" |");
        }
        Console.WriteLine(" ]");
    }
}

int[,] ReplaceElemntsMatrix(int[,] matrix)
{
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
    return matrix;
}



if (m == n)
{
    int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, 1, 100);
    Console.WriteLine("массив заполненный случайными целыми числами");
    PrintMatrix(newMatrixRndInt);
    Console.WriteLine("массив измененнный");
    int[,] replaceMatrix = ReplaceElemntsMatrix(newMatrixRndInt);
    PrintMatrix(replaceMatrix);
    // int[,] reverseMatrix = ReverseElemntsMatrix(newMatrixRndInt);
    // PrintMatrix(reverseMatrix);
}
else Console.WriteLine("перестановка элементов не возможна");


// int[,] ReverseElemntsMatrix(int[,] matrix)
// {
//     int temp = default;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             temp = matrix[i, j];
//             matrix[i, j] = matrix[matrix.GetLength(0)-1-i, matrix.GetLength(0)-1-j];
//             matrix[matrix.GetLength(1)-1-j, matrix.GetLength(0)-1-i] = temp;
//         }
//     }
//     return matrix;
// }
