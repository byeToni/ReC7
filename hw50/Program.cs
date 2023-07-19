// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
using System;
using static System.Console;
Clear();
WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

int count_str = Get_int("Введите количество строк в массиве: ");
int count_col = Get_int("Введите количество столбцов в массиве: ");
double[,] arr = new double[count_str, count_col];
int s = Get_int("Введите номер строки: ");
int c = Get_int("Введите номер позиции: ");
FillArray(arr);
while (!TestResult(s - 1, c - 1, count_col, count_str))
{
    WriteLine("Введите новые данные! ");
    s = Get_int("Введите номер строки: ");
    c = Get_int("Введите номер позиции: ");
}
PrintArray(arr);
WriteLine($"Значение элемента в массиве в позиции {s}:{c} '{arr[s - 1, c - 1]:f1}'");

bool TestResult(int s, int c, int c_cl, int c_str)
{
    if (s >= 0 && c >= 0 && s < c_cl && c < c_str) return true;
    else
    {
        WriteLine("Позиции элемента не входят в диапазон массива");
        return false;
    }
}

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