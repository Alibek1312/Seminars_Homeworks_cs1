// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Creat2DRandomDoubleArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for (int i = 0; i< rows; i++)
//     {
//         for (int j = 0; j< columns; j++)
//         {
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     double[,] myArrayDouble = new double[rows, columns];
//     for (int i = 0; i< rows; i++)
//     {
//         for (int j = 0; j< columns; j++)
//         {
//             myArrayDouble[i, j] = Math.Round(new Random().NextDouble() + myArray[i,j], 2);
//         }
//     }   
//     return myArrayDouble;
// }

// void Show2DArray(double[,] array) // чтобы созданный нами массив показать на консоле нам нужно данная функция
// {
//     for (int i = 0; i< array.GetLength(0); i++)
//     {
//         for (int j = 0; j< array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Creat2DRandomDoubleArray(rows, columns, minValue, maxValue));


// ----------------------------------------------------------------
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// double[,] Creat2DRandomDoubleArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     double[,] myArrayDouble = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             myArrayDouble[i, j] = Math.Round(new Random().NextDouble() + myArray[i, j], 2);
//         }
//     }
//     return myArrayDouble;
// }

// void Show2DArray(double[,] array) // чтобы созданный нами массив показать на консоле нам нужно данная функция
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void PokazatElement2DArray(double[,] array, int row, int column)
// {
//     if (row>array.GetLength(0) && column>array.GetLength(1))
//         {
//         Console.WriteLine("V matrise otsutsvuet dannaya pozisiya");
//         }
//     else
//         {
//         object element = array.GetValue(row,column);
//         Console.WriteLine($"Chislo ukazannoy pozisii {element}");
//         }
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию строк ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию столбцов ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// double[,] myArray = Creat2DRandomDoubleArray(rows, columns, minValue, maxValue);
// Show2DArray(myArray);
// PokazatElement2DArray(myArray, row, column);

// ------------------------------------------------------------------------------------------------
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Creat2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] myArray = new int[rows, columns];
    for (int i = 0; i< rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
            myArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return myArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SrednayaArfmetikaPoStolbsu(int [,] array)
{
    double SredArif = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            SredArif = SredArif + array[i, j];
            // Console.Write($" {SredArif/array.GetLength(0)} ");
            // SredArif = 0;
        }
    Console.Write($" {SredArif/array.GetLength(0)} ");
    SredArif = 0;
    }
}

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Creat2DRandomArray(rows, columns, minValue, maxValue);
Show2DArray(myArray);
Console.WriteLine();
SrednayaArfmetikaPoStolbsu(myArray);
