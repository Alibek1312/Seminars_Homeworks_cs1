//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] PoUbivaniyuArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
//   return array;
// }


// int[,] Creat2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for (int i = 0; i< rows; i++)
//     {
//         for (int j = 0; j< columns; j++)
//         {
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray(int[,] array)
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

// int[,] myArray = Creat2DRandomArray(rows, columns, minValue, maxValue);
// Show2DArray(myArray);
// Console.WriteLine();
// Show2DArray(PoUbivaniyuArray(myArray));


// --------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// void MinSumStrok(int[,] array)
// {
//     int[] summastrok = new int[array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             summastrok[i] = summastrok[i] + array[i, j];           
//         }
        
//     //Console.WriteLine(summastrok[i]); 
//     }

//     int summin = summastrok[0];
//     int minI = 0;
//     for (int i = 0; i < summastrok.Length; i++)
//     { 
//         if (summastrok[i] < summin)
//             {
//                 summin = summastrok[i];
//                 minI = i;
//             }
//     }
//     Console.Write($"Summ of numbers minimum columns is --> {summastrok[minI]} and column number is --> {minI+1} ");
// }


// int[,] Creat2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for (int i = 0; i< rows; i++)
//     {
//         for (int j = 0; j< columns; j++)
//         {
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray(int[,] array)
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

// int[,] myArray = Creat2DRandomArray(rows, columns, minValue, maxValue);
// Show2DArray(myArray);
// Console.WriteLine();
// MinSumStrok(myArray);



// ------------------------------------------------------------------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] Create3DRandomArray (int x, int y, int z, int minValue, int maxValue)
// {
//     int[,,] myArray = new int[x, y, z];
//     for(int i = 0; i < x; i++)
//     {
//         for(int j = 0; j < y; j++)
//         {
//             for(int k = 0; k < z; k++)
//             {
//                 myArray[i, j, k] = new Random().Next(minValue, maxValue + 1);                 
//             }
//          }
//     }
//     return myArray;
// }

// void Show3DArray (int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             for(int k = 0; k < array.GetLength(2);k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите количество строк ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество глубины ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(x, y, z, minValue, maxValue);

// Show3DArray(myArray);

// ------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreateFirst2DMatrix (int rows1, int columns1, int minValue, int maxValue)
// {
//     int[,] firstMatrix = new int[rows1, columns1];
//     for(int i = 0; i < rows1;i++)
//     {
//         for(int j = 0; j < columns1;j++)
//         {
//             firstMatrix[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return firstMatrix;
// }

// int[,] CreateSecond2DMatrix (int rows2, int columns2, int minValue, int maxValue)
// {
//     int[,] secondMatrix = new int[rows2, columns2];
//     for(int i = 0; i < rows2;i++)
//     {
//         for(int j = 0; j < columns2;j++)
//         {
//             secondMatrix[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return secondMatrix;
// }

// int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {
//     if(firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
//     {
//         Console.WriteLine("Multiplication matrix is not possible");
//     }
//     int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
//     for(int i = 0; i < firstMatrix.GetLength(0);i++)
//     {
//         for(int j = 0; j < secondMatrix.GetLength(1);j++)
//         {
//             resultMatrix[i,j] = 0;
//             for(int k = 0; k < firstMatrix.GetLength(1);k++)
//             {
//                 resultMatrix[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
//             }
//         }
//     }
//     return resultMatrix;
// }

// void Show2DMatrix (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input the number of rows for the first matrix: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns for the first matrix: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of rows for the second matrix: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns for the second matrix: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] firstMatrix = CreateFirst2DMatrix(rows1, columns1, minValue, maxValue);
// Console.WriteLine("First matrix: ");
// Show2DMatrix(firstMatrix);

// int[,] secondMatrix = CreateSecond2DMatrix(rows2, columns2, minValue, maxValue);
// Console.WriteLine("Second matrix: ");
// Show2DMatrix(secondMatrix);

// int[,] multiplicationMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
// Console.WriteLine("Result multiplication matrix: ");
// Show2DMatrix(multiplicationMatrix);


//-----------------------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] FillArraySpiral(int rowP, int colP, int count, int[,] array)
// {
//         //заполнение периметра
//     for (int j = 0; j < colP; j++)
//     {
//         array[0, j] = count;
//         count++;
//     }
//     for (int i = 1; i < rowP; i++)
//     {
//         array[i, colP - 1] = count;
//         count++;
//     }
//     for (int j = colP - 2; j >= 0; j--)
//     {
//         array[rowP - 1, j] = count;
//         count++;
//     }
//     for (int i = rowP - 2; i > 0; i--)
//     {
//         array[i, 0] = count;
//         count++;
//     }
//         // заполнение массива по спирали
//     int row = 1;
//     int col = 1;

//     while (count < rowP * colP)
//     {
//         while (array[row, col + 1] == 0)        // >>
//         {
//             array[row, col] = count;
//             count++;
//             col++;
//         }

//         while (array[row + 1, col] == 0)        // v
//         {
//             array[row, col] = count;
//             count++;
//             row++;
//         }

//         while (array[row, col - 1] == 0)        // <<
//         {
//             array[row, col] = count;
//             count++;
//             col--;
//         }

//         while (array[row - 1, col] == 0)        // ^
//         {
//             array[row, col] = count;
//             count++;
//             row--;
//         }
//     }
//         // Заменяем оставшийся 00 в центре крайним числом из последовтельности
//     for (int i = 0; i < rowP; i++)
//     {
//         for (int j = 0; j < colP; j++)
//         {
//             if (array[i, j] == 0)
//             {
//                 array[i, j] = count;
//             }
//         }
//     }
//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10) Console.Write($" 0{array[i, j]}");
//             else Console.Write($" {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input the length of square array: ");
// int rowP = Convert.ToInt32(Console.ReadLine());
// int colP = rowP;
// Console.Write("Input first digit of array: ");
// int count = Convert.ToInt32(Console.ReadLine());;
// int[,] array = new int[rowP, colP];
// array = FillArraySpiral(rowP, colP, count, array);
// Show2DArray(array);