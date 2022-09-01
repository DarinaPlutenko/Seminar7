// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[,]{{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

Console.Write("Среднее арифметическое каждого столбца: ");

for (int columnNumber = 0; columnNumber < matrix.GetLength(1); columnNumber++)
{
    double sum = 0;

    for (int rowNumber = 0; rowNumber < matrix.GetLength(0); rowNumber++)
    {
        sum = sum + matrix[rowNumber, columnNumber];
    }

    double average = sum/matrix.GetLength(0);

    if (columnNumber > 0)
    {
        Console.Write("; ");
    }
    Console.Write($"{average:f2}");
}
Console.WriteLine(".");