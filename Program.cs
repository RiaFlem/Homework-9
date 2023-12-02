// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NToOne (int n, int count)
// {
//     if (count <= n)
//     {
//         NToOne (n, count + 1);
//         System.Console.Write (count + " ");
//     }

// }
// NToOne (8, 1);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumOfMToN (int n, int m)
// {
//     if (m != n)
//     {
//         if (n > m)
//         {
//             return SumOfMToN (n - 1, m) + n;
//         }
//         else
//         {
//             return SumOfMToN (n, m - 1) + m;
//         }
//     }
//     else return m;
// }
// System.Console.Write (SumOfMToN(1, 15));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AkkermanFunction (int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return AkkermanFunction (m - 1, 1);
//     }
//     else
//     {
//         return (AkkermanFunction(m - 1, AkkermanFunction (m, n - 1)));
//     } 
// }
// System.Console.Write (AkkermanFunction (2, 3));

// void NToOne (int n)
// {
//     if (n > 0)
//     {
//         System.Console.Write (n + " ");
//         NToOne (n - 1);
//     }
// }
// NToOne (5);