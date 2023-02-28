// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Input three digit number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int SecondDigit (int num)
// {
//     int l = num / 10;
//     int k = l % 10;
//     return k;
// }
// int result = SecondDigit(a);
// Console.WriteLine($"Second digit of {a} --> {result}");


// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

// Console.Write("Input three and more digit number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// void ThD(int t)
// {
//     string k = Convert.ToString(t);
//     if (k.Length >= 3)
//     {
//        Console.WriteLine("Third number is --> " + k[2]);
//     }
//     else
//     {
//         Console.WriteLine("There is not third digit");
//     }
// }
// ThD(a);

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет


// Console.Write("Input day number of the week for checking weekend: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());

// void CheckDay (int dayNum)
// {
//   if (dayNum == 6 || dayNum == 7) 
//   {
//   Console.WriteLine("Weekend");
//   }
//   else if (dayNum < 1 || dayNum > 7) 
//   {
//     Console.WriteLine("Check day number of the week");
//   }
//   else Console.WriteLine("Today working day");
// }

// CheckDay(dayNum);