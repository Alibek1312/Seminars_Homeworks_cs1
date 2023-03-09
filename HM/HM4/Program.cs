// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int FindDeg(int A, int B)
// {
//     int res = Convert.ToInt32(Math.Pow(A, B));
//     return res;
// }
// Console.Write("Input number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Degree {A} of {B} is {FindDeg(A, B)}");

// -----------------------------------------------------------------------------------
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int FindDigitSum(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum += num % 10;
//         num = num / 10;
//     }
//     return sum;
// }

// Console.Write("Input number for find digits sum: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Digits sum of {num} is {FindDigitSum(num)}");


// -----------------------------------------------------------------------------------
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateRandomArray(size, minValue, maxValue));


