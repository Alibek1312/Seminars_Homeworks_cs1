// // WriteLine может вывести на терминал определнное значение или переменное, которое заранее объявляется
// // ReadLine может читать с терминала в алгоритм значение
// // int целое число
// // double рациональное число
// // int a = Convert.ToInt32(Console.Readline()) - когда просится через терминал ввод данных через Console.Readline() -->
// // --> то введенное значение считается строкой (String). Чтобы перевести строку в число (int) нужно конвертировать с помощью оператора Convert.ToInt32
// // 
// //----------------------------------------------------------------------------------------------------------
// // Seminar Arxip: запросим число и покажем

// Console.Write("Input yor favourite number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your favourite number is " + a + ".");


// //----------------------------------------------------------------------------------------------------------
// // Seminar Ex1: Запросим у пользователья число а в результате покажем квадрат введенного числа

// Console.Write("Input number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("The quad is your input number is: " + b * b);


// //----------------------------------------------------------------------------------------------------------
// // Seminar Ex2: Запросим у пользоватеья два числа и проверим является ли первое число квадратом второго числа

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num2 * num2 == num1)
// {
//     Console.WriteLine($"First number {num1} is quad of Second number {num2}");
// }
// else
// {
//     Console.WriteLine($"First number {num1} is not quad of Second number {num2}");
// }


// //----------------------------------------------------------------------------------------------------------
// // Seminar Ex3: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Input N: ");
// int t = Convert.ToInt32(Console.ReadLine());
// int f = t * (-1);
// while (f <= t)
// {
//     Console.Write(f + "  ");
//     f++;
// }

// //----------------------------------------------------------------------------------------------------------
// // Ex4: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа

// Console.Write("Input number in three-digit: ");
// int r = Convert.ToInt32(Console.ReadLine());
// if (r>=100 && r < 1000)
// {
//     int remainder = r % 10;
//     Console.WriteLine($"Last digit of your input number is {remainder}");
// }
// else
// {
//     Console.WriteLine("Your number is not in three-digit. Input number in three-digit please");
// }

