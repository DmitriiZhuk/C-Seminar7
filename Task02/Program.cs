/*
Задача 50. Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

// 1 Запрашиваю позиции		
Console.Write("Введите позицию элемента в строке: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию элемента в  столбце: ");
int colPosition = Convert.ToInt32(Console.ReadLine());

// 2 Объект - случайные числа.
Random rnd = new Random();

// 3 Объявляю двумерный массив размером m×n
//со случайным количеством строк и столбцов
int nRow = rnd.Next(3, 10);
int nCol = rnd.Next(3, 10);

int[,] numArray = new int[nRow, nCol];

// 4 Заполняю массив, вывожу на экран.		
for (int i = 0; i < numArray.GetLength(0); i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
    {
        numArray[i, j] = rnd.Next(1, 10000);
        Console.Write(numArray[i, j] + " ");
    }
    Console.WriteLine();
}

if (rowPosition < numArray.GetLength(0) && colPosition < numArray.GetLength(1))
{
    Console.WriteLine("Элемент с заданными позициями - " + numArray[rowPosition, colPosition]);
}
else
{
    Console.WriteLine("Элемента с заданными позициями не существует");
}