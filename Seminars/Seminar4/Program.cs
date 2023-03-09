//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36


// int FindSum (int num)
// {
// int sum = 0;
// for (int current = 1; current <= num; current++)
// {
// sum += current;
// }
// return sum;
// }

// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine( ));
// Console.WriteLine($"Summ of numbers from 1 to {num} is {FindSum(num)}");


// ----------------------------------------------------------------
//Задача 4. Напишите программу, которая выводит массив из N элементов, заполненный случайными числами в случайном порядке.
// 

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

// Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(size, minValue, maxValue));


// ------------------------------------------------------------------------------------------------
//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

// int FindFactorial(int num)
// {
//     int fact = 1; 
//     for (int i = 1; i <= num; i++)
//     {
//         fact *=i;
//     }
//     return fact;
// }

// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Factorial of {num} is {FindFactorial(num)}");

//--------------------------------------------------------------------------------------------------
//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int FindDigitNum (int num)
{
    int i = 1;
    while (num > 10)
    {
        num = num / 10;
        i++;
    }
    return i;
}

Console.Write ("Input number for find digitnumbers: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Digitnumbers of {num} is {FindDigitNum(num)}");

