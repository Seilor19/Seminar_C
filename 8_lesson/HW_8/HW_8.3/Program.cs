Console.Write("Кол-во строк 1ой матрицы ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов 1ой матрицы ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];
Console.Write("Кол-во столбцов 2 ой матрицы ");
int Scol = int.Parse(Console.ReadLine()!);
int[,] Smatrix = new int[row, Scol];

Console.Write("Введите минимальное значение элемента матрицы : ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента матрицы : ");
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

int[,] ResMatrix = new int[row,Scol];

int MultiMatrix(int[,] matrix, int[,] Smatrix, int[,] ResMatrix)
{
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
        {
            int sum = 0;
            for (int k = 0; k < col; k++)
                {
                    sum += matrix[i,k] * Smatrix[k,j];
                }
            ResMatrix[i,j] = sum;
        }
  }
  
}
FillArray(matrix);
PrintArray(matrix);
FillArray(Smatrix);
Console.WriteLine();
PrintArray(Smatrix);

MultiMatrix(matrix, Smatrix, ResMatrix);
PrintArray(ResMatrix);