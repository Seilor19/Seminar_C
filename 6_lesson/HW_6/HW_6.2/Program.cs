//Напишите программу, которая будет создавать
//копию заданного массива с помощью поэлементного
//копирования. 

Console.Write("Кол-во строк ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов ");
int col = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[row, col];
int[,] copy = new int[row, col];

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }

    }
}

void CopyArray(int[,] copy)
{   for (int i = 0; i <= row-1; i++)
    {
        for (int j = 0; j < col; j++)
            {
            copy[i,j] = matrix[i,j];
            }
    }
}



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

void PrintCopy(int[,] copy)
{
    for (int i = 0; i < copy.GetLength(0); i++)
    {
        for (int j = 0; j < copy.GetLength(1); j++)
        {
            Console.Write($"{copy[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
CopyArray(copy);
PrintCopy(copy);