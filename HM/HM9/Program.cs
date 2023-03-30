// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"



// void ShowNumbersFromNToOne(int n)
// {
//     if(n>=1)
//     {
//         Console.Write(n+" ");
//         ShowNumbersFromNToOne(n-1);
//     }
// }

// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// ShowNumbersFromNToOne(num);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120


// int SumNumbersFromMToN(int m, int n)
// {
//     if(m != n)
//     {
//         if(m <= n)
//         {
//             return SumNumbersFromMToN(m + 1, n) + m;
//         }
//         else
//         {
//             return SumNumbersFromMToN(m, n + 1) + n;
//         }
//     }
//     else return m;
// }

// Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Sum of the numbers from {m} to {n} -> {SumNumbersFromMToN(m, n)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


int FunctionAkkermana(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkkermana(m - 1, 1);
    else return FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1));
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {FunctionAkkermana(m, n)}");