// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Задайте свой массив");
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i,j] + "\t  ");
        Console.WriteLine();}

for (int rowNumber = 0; rowNumber < matrix.GetLength(0); rowNumber++)
{
    for (int columnNumber = 0; columnNumber < matrix.GetLength(1); columnNumber++)
    {
        Console.Write($"{matrix[rowNumber, columnNumber]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите координаты искомого числа");
Console.WriteLine("Введите номер строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер стобца");
int column = Convert.ToInt32(Console.ReadLine());

if ((row < 0 || row >= matrix.GetLength(0)) || (column < 0 || column >= matrix.GetLength(1)))
{
    Console.WriteLine("Элемента с таким индексом в данной матрице не существует");
    return;
}

Console.WriteLine($"В матрице, в строке {row}, в колонке {column} находится значение: {matrix[row, column]}");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}