// 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
//    выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int min, int max)
{
    Console.WriteLine("\nМассив:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}
void MassNum(int[,] matr)
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == num)
                Console.WriteLine($"Адрес  {i + 1} {j + 1}");

        }
    }
}

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];
Console.Write("Введите минимальное значение элемента массива : ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int stop = int.Parse(Console.ReadLine()!);

FillArray(matrix, start, stop);
PrintArray(matrix);
MassNum(matrix);

// // 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// //    выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write($"{matr[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }

// }
// string FindNum(int[,] arr, int num)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i, j] == num) return $"[{i + 1}, {j + 1}]";
//         }
//     }
//     return "Not find";
// }


// Console.WriteLine("Введите количество строк ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите искомое число ");
// int a = int.Parse(Console.ReadLine()!);
// int[,] matrix = new int[m, n];

// FillArray(matrix);
// PrintArray(matrix);
// System.Console.WriteLine();
// System.Console.WriteLine(FindNum(matrix, a));