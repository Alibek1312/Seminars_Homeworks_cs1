// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         if (minValue > 99 && maxValue <= 999) newArray[i] = new Random().Next(minValue, maxValue + 1);
//         else newArray[i] = -1;
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

// int FindDevTwo(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
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

// int[] array = CreateRandomArray(size, minValue, maxValue);
// ShowArray(array);
// Console.Write(FindDevTwo(array));



// ---------------------------------------------------------------------------------------
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// int SumOddPositionDigits(int[] array)
// {
//     int SumOddPosition = 0;
//     for (int i = 1; i < array.Length; i+=2)
//     {
//         SumOddPosition += array[i];
//     }
//     return SumOddPosition;
// }

// Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myarray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myarray);
// Console.Write($"Summ of odd position digits is --> {SumOddPositionDigits(myarray)}");

// ---------------------------------------------------------------------------------------
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }

    // double[] newArrayDouble = new double[size];
    // for (int i = 0; i < size; i++)
    // {
    //     newArrayDouble[i] = new Random().Next(minValue, maxValue + 1);
    // }
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

int DifMaxAndMinDigits(int[] array)
{
    int minDig = array[0];
    int maxDig = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minDig)
        {
            minDig = array[i];
        } 
        else if (array[i] > maxDig)
        {
            maxDig = array[i];
        }
    }
    return maxDig-minDig;
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myarray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myarray);
Console.Write($"Difference of max and min digits is --> {DifMaxAndMinDigits(myarray)}");
