// 1 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// Console.Write("Input your number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// bool Kratnost(int num)
// {
//     if (num % 7 == 0 && num % 23 ==0) return true;
//     else return false;
// }

// bool result = Kratnost(a);
// Console.WriteLine(result);



// 2 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("Input your number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your number 2: ");
int b = Convert.ToInt32(Console.ReadLine());


bool Kvadrat(int num1, int num2)
{
    if (num2 == num1 * num1 || num1 == num2 * num2) return true;
    else return false;
}

bool result = Kvadrat(a, b);
Console.WriteLine(result);