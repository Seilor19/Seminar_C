//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[a];

void mass(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(99,999);
Console.Write(randomArray[i] + " " );
}

}

int kolichestvo(int[] randomArray)
{
int kol = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
kol = kol + 1;
}
return kol;
}

mass(a);
Console.WriteLine(" ");
Console.Write($"Количество чётных чисел в массиве: {kolichestvo(randomArray)}");