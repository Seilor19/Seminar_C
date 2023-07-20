// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Кол-во строк ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];

Console.Write("Введите минимальное значение элемента массива : ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int max = int.Parse(Console.ReadLine()!);


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
}
FillArray(matrix);
PrintArray(matrix);

int RowSum(int[,] matrix, int i)
    {
        int sum = matrix[i,0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        return sum;
    }

int minSum = 1;
int sum = RowSum(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (sum > RowSum(matrix, i))
    {
        sum = RowSum(matrix, i);
        minSum = i+1;
    }
}   
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");




