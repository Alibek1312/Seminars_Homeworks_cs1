//
//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void SumPosNegDigits(int[] array)
// {
//     int SumPos = 0;
//     int SumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) SumPos+= array[i];
//         else SumNeg+= array[i];
//     }
//     Console.WriteLine($"Sum of positive digits is --> {SumPos} and sum of negative digits is --> {SumNeg}");
// }

// Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myarray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myarray);
// SumPosNegDigits(myarray);



// ----------------------------------------------------------------------------------
//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ChangeDirect(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }

// Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myarray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myarray);
// int[] newarray = ChangeDirect(myarray);
// ShowArray(newarray);

// ----------------------------------------------------------------------------------------
//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// { 
//     int[] newArray = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     { 
//         newArray[i] = new Random().Next(minValue, maxValue + 1); 
//     } 
//     return newArray; 
// } 
 
// void ShowArray(int[] array) 
// { 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         Console.Write(array[i] + " "); 
//     } 
//     Console.WriteLine(); 
// } 
 
// bool FindNum(int num, int[] array) 
// { 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         if (array[i] == num) 
//         { 
//             return true; 
//         } 
//      } 
//         return false; 
//     } 
// Console.Write("Input array size:"); 
// int size = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input minimal value of array element:"); 
// int minValue = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input maximal value of array element:"); 
// int maxValue = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input num:"); 
// int num = Convert.ToInt32(Console.ReadLine()); 
// int[] array = CreateRandomArray(size, minValue, maxValue); 
// ShowArray(array); 
// Console.Write(FindNum(num, array)); 
 
// ----------------------------------------------------------------------------------------------
//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,  
//значения которых лежат в отрезке [10,99]. 
 
// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// { 
//     int[] newArray = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     { 
//         newArray[i] = new Random().Next(minValue, maxValue + 1); 
//     } 
//     return newArray; 
// } 
 
// void ShowArray(int[] array) 
// { 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         Console.Write(array[i] + " "); 
//     } 
//     Console.WriteLine(); 
// } 
 
// int FindCountArray(int minNum, int maxNum, int[] array) 
// { 
//     int count = 0; 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         if (array[i] >= minNum && array[i] <= maxNum) 
//         { 
//             count++; 
//         } 
//     } 
//     return count; 
// } 
 
// Console.Write("Input array size:"); 
// int size = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input minimal value of array element:"); 
// int minValue = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input maximal value of array element:"); 
// int maxValue = Convert.ToInt32(Console.ReadLine()); 
 
// Console.Write("Input MinNum:"); 
// int minNum = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input MaxNum:"); 
// int maxNum = Convert.ToInt32(Console.ReadLine()); 
 
// int[] array = CreateRandomArray(size, minValue, maxValue); 
// ShowArray(array); 
// Console.Write(FindCountArray(minNum, maxNum, array));