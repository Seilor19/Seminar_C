Console.Write("Кол-во строк 1ой матрицы ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов 1ой матрицы ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];

Console.Write("Кол-во строк 2 ой матрицы ");
int Srow = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов 2 ой матрицы ");
int Scol = int.Parse(Console.ReadLine()!);
int[,] Smatrix = new int[Srow, Scol];

Console.Write("Введите минимальное значение элемента матрицы : ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента матрицы : ");
int max = int.Parse(Console.ReadLine()!);

if (col != Srow)
{
  Console.WriteLine("Такие матрицы умножать нельзя!");
  return;
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



int[,] MultiMatrix(int[,] matrix, int[,] Smatrix)
{
   
    int[,] arrayC = new int[matrix.GetLength(0), Smatrix.GetLength(1)];
 
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < Smatrix.GetLength(1); j++)
        {
          for (int k = 0; k < matrix.GetLength(1); k++)
          {
            arrayC[i, j] += matrix[i, k] * Smatrix[k, j];
          }
        }
      }
      return arrayC;
 }
  
    
   


FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

FillArray(Smatrix);
PrintArray(Smatrix);

Console.WriteLine();

MultiMatrix(matrix, Smatrix);
PrintArray(MultiMatrix(matrix, Smatrix));