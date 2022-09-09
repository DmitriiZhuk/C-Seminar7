/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


// 1 Объявляю двумерный массив размером m×n
double[,] numArray = new double[3, 4];

// 2 Объект - случайные числа.
Random rnd = new Random();

// 3 Заполняю массив, вывожу на экран.		
for (int i = 0; i < numArray.GetLength(0); i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
    {
        numArray[i, j] = (double) rnd.Next(1, 1000000);
        Console.Write(numArray[i, j] + " ");
    }
    Console.WriteLine();
}