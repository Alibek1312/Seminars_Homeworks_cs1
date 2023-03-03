//Задание1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0  
// и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuart(double x, double y)
// {
//     if (x > 0 && y > 0)
//         return 1;
//     if (x < 0 && y > 0)
//         return 2;
//     if (x < 0 && y < 0)
//         return 3;
//     if (x > 0 && y < 0)
//         return 4;
//     return 0; //Console.WriteLine("Не введите число 0 на х и у");
// }

// Console.Write("Input X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input Y: ");
// double y = Convert.ToDouble(Console.ReadLine());

// Console.Write($"Point located at {FindQuart(x, y)} - quart");


// ----------------------------------------------------------------
//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double x1, double y1, double x2, double y2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
// }

// Console.Write("Input x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Points distance is - {FindDistance(x1, y1, x2, y2)}");

// ----------------------------------------------------------------
// Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindDiap(int num)
// {
//     if (num == 1)
//         Console.WriteLine("Диапазон значения x > 0 and y > 0");
//     if (num == 2)
//         Console.WriteLine("Диапазон значенияx < 0 and y > 0");
//     if (num == 3)
//         Console.WriteLine("Диапазон значения x < 0 and y < 0");
//     if (num == 4)
//         Console.WriteLine("Диапазон значения x > 0 and y < 0");
//     if (num < 1 || num > 4)
//         Console.WriteLine("input number in interval [1, 4]");
// }

// Console.Write("Input number from 1 to 4: ");
// // //int n = Convert.ToInt32(Console.ReadLine());
// FindDiap(Convert.ToInt32(Console.ReadLine()));


// ----------------------------------------------------------------
//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

void QuadNumbers(int num)
{
    int f = 1;
    while (f <= num)
    {
        Console.WriteLine($"The quad of {f} is {f*f}");
        f++;
    }
}
Console.Write("Input number: ");
QuadNumbers(Convert.ToInt32(Console.ReadLine()));