// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using System;
using static System.Console;
Clear();
WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
int count_str = Get_int("Введите количество строк в массиве: ");
int count_col = Get_int("Введите количество столбцов в массиве: ");
int[,] arr = new int[count_str, count_col];
FillArray(arr, 0, 15);
WriteLine("Рэндомный массив: ");
PrintArray(arr);

double[] rez_arr = new double[count_col];
for (int i = 0; i < count_col; i++)
{
    for (int j = 0; j < count_str; j++)
    {
        rez_arr[i] += arr[j, i];
    }
}
WriteLine("Массив сумм столбцов: ");
PrintArrayD(rez_arr);
WriteLine("");
WriteLine("Среднее арифметическрое по столбцам: ");
for (int i = 0; i < rez_arr.Length; i++)
{
    WriteLine($"{rez_arr[i]/count_str} ");
}

void FillArray(int[,] coll, int count_str, int count_col)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(count_str, count_col + 1);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}

int Get_int(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}

void PrintArrayD(double[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Write($"{arr[i]:f1} ");
    }
}