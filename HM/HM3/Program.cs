// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palid(int t)
// {
//     string k = Convert.ToString(t);
//     if (k.Length == 5 && k[0]==k[4] && k[1]==k[3])
//        Console.WriteLine("Your five digit number is Palidrome.");
//     else if (k.Length > 5 | k.Length <= 4)
//         Console.WriteLine("This is wrong digit.");
//     else
//         Console.WriteLine("Your five digit number is NOT Palidrome.");
// }
// Console.Write("Input five digit int number: ");
// Palid(Convert.ToInt32(Console.ReadLine()));


// ----------------------------------------------------------------
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance3(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
// }

// Console.Write("Input point of A --> x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input point of A --> y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input point of A --> z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input point of B --> x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input point of B --> y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input point of B --> z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Points distance is - {FindDistance3(x1, y1, z1, x2, y2, z2)}");


// ----------------------------------------------------------------
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void KubNumbers(int num)
// {
//     int f = 1;
//     while (f <= num)
//     {
//         Console.WriteLine($"The kub of {f} is {f*f*f}");
//         f++;
//     }
// }
// Console.Write("Input number: ");
// KubNumbers(Convert.ToInt32(Console.ReadLine()));


