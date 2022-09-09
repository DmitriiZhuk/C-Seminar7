/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// 1 Объект - случайные числа.
Random rnd = new Random();

// 2 Объявляю двумерный массив размером m×n
//со случайным количеством строк и столбцов
int nRow = rnd.Next(3, 7);
int nCol = rnd.Next(2, 5);

int[,] numArray = new int[nRow, nCol];

// 3 Заполняю массив, вывожу на экран.		
for (int i = 0; i < numArray.GetLength(0); i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
    {
        numArray[i, j] = rnd.Next(1, 100);
        Console.Write(numArray[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 3 Среднее арифметическое столбцов.
double sumCol = 0;
for (int i = 0; i < numArray.GetLength(1); i++)
{
    for (int j = 0; j < numArray.GetLength(0); j++)
    {
        sumCol = sumCol + numArray[j, i];
    }
    Console.WriteLine("Среднее арифметическое столбца " + (i + 1) + " = " + (sumCol / nRow));
    sumCol = 0;
}