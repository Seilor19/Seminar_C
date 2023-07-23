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

int[,] FindPositionSmallElement(int[,] matrix, int[,] position)
{
  int temp = matrix[0, 0];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] <= temp)
      {
        position[0, 0] = i;
        position[0, 1] = j;
        temp = matrix[i, j];
      }
    }
  }
  Console.WriteLine($"\nMинимальный элемент: {temp}");
  return position;
}

void DeleteLines(int[,] matrix, int[,] positionSmallElement, int[,] arrayWithoutLines)
{
  int k = 0, l = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
      {
        arrayWithoutLines[k, l] = matrix[i, j];
        l++;
      }
    }
    l = 0;
    if (positionSmallElement[0, 0] != i)
    {
      k++;
    }
  }
}
FillArray(matrix);
PrintArray(matrix);

int[,] positionSmallElement = new int[1, 2];
positionSmallElement = FindPositionSmallElement(matrix, positionSmallElement);
Console.Write($"Позиция элемента: \n");
PrintArray(positionSmallElement);

int[,] arrayWithoutLines = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
DeleteLines(matrix, positionSmallElement, arrayWithoutLines);
Console.WriteLine($"\nПолучившийся массив:");
PrintArray(arrayWithoutLines);

