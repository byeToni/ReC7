// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;
using static System.Console;
Clear();
WriteLine("Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");

int m = Get_int("Введите количество строк (m): ");
int n = Get_int("Введите количество столбцов (n): ");
double[,] arr = new double[m, n];
FillArray(arr);
PrintArray(arr);

int Get_int(string message)
{
    Write(message);

    return int.Parse(ReadLine());
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]:f1} ");
        }
        WriteLine();
    }
}


void FillArray(double[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().NextDouble() * 100;
        }

    }
}