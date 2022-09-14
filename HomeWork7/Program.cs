﻿//==========Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] GetArray(int rows, int column)
// {
//     double[,] array = new double[rows, column];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < column; j++)
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//     return array;
// }

// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите число m: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int column = Convert.ToInt32(Console.ReadLine());
// double[,] array = GetArray(rows, column);
// ShowArray(array);



// =============Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("введите номер строки: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[10, 10];
// RandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("Такого элемента в массиве нет");
// }
// else
// {
//     Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
// }

// PrintArray(numbers);

// void RandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-100, 100) / 10;
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

//===============Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
RandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double med = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        med = (med + numbers[i, j]);
    }
    med = med / n;
    Console.Write(med + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}