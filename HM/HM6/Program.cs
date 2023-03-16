// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int ZaprosChisel(string text) // Переводчик запрошенных чисел из строки (string) в число (int)
// {
//     Console.Write(text);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[] SozdatMassiv(int size) // Запросим у пользователья ввести число для каждого элемента массива
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = ZaprosChisel($"Vvedite {i + 1} element massiva: ");
//     }
//     return array;
// }

// void PokazatMassiv(int[] array) // Показываем массив
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//        Console.Write(array[i] + " ");
//         //Console.WriteLine($"a[{i}] = {array[i]}");
//     }
//     Console.WriteLine();
// }

// int KolichestvoPolojitelnixChisel(int[] array)  // Находим количество положительных чисел
// {
//     int j = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             j++;
//         }
//     }
//     return j;
// }

// int size = ZaprosChisel("Vvedite razmer massiva: ");
// int[] array = SozdatMassiv(size);
// PokazatMassiv(array);
// Console.WriteLine($"Kolichestvo polojitelnix chisel --> {KolichestvoPolojitelnixChisel(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int K = 0;
int B = 1;
int X_COORD = 0;
int Y_COORD = 1;
int Line1 = 1;
int Line2 = 2;


double ZaprosChislo(string text)
{
    Console.Write(text);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

double[] SozdatFunksiyu(int number)  // запрашиваем коэффициенты и константы для каждой функции
{
    double[] lineData = new double[2];
    lineData[K] = ZaprosChislo($"Vvedite chislo dlya koeffisiyenta {number} funksii: ");
    lineData[B] = ZaprosChislo($"Vvedite chislo dlya konstanti {number} funksii: ");
    return lineData;
}

double[] KoordinataPeresecheniy(double[] lineData1, double[] lineData2) // Находим координату пересечений функции
{
    double[] koordinata = new double[2];
    koordinata[X_COORD] = (lineData1[B] - lineData2[B]) / (lineData2[K] - lineData1[K]);
    koordinata[Y_COORD] = lineData1[B] * koordinata[X_COORD] + lineData1[B];
    return koordinata;
}

bool ProverkaFunksii(double[] lineData1, double[] lineData2) // Проверяем состоянии созданных функций
{
    if (lineData1[K] == lineData2[K])
    {
        if (lineData1[B] == lineData2[B])
        {
            Console.WriteLine("Funksii odinakovie");
            return false;
        }
        else
        {
            Console.WriteLine("Funksii parallelni");
            return false;
        }
    }
    return true;
}


double[] lineData1 = SozdatFunksiyu(Line1);
double[] lineData2 = SozdatFunksiyu(Line2);

if (ProverkaFunksii(lineData1, lineData2))
{
    double[] coord = KoordinataPeresecheniy(lineData1, lineData2);
    Console.WriteLine($"Koordinata peresecheniya funksiy --> {coord[X_COORD]} , {coord[Y_COORD]}");
}