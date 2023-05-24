// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int M = GetInt("Введите число M");
// int N = GetInt("Введите число N");
// int sum = 0;

// if (M < N) GetSum(M, N);
// else GetSum(N, M);
// Console.WriteLine($"Сумма Натуральных чисел в промежутке от {M} до {N} составит {sum}");

// int GetInt(string str)
// {
//     System.Console.Write(str + " ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// void GetSum(int num1, int num2)
// {
//     if (num1 > num2) return;

//     sum += num1;
//     GetSum(num1 + 1, num2);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int m = GetInt("Введите число m");
// int n = GetInt("Введите число n");

// Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {Ackermann(m, n)}");

// int GetInt(string str)
// {
//     System.Console.Write(str + " ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Ackermann(int numM, int numN)
// {
//     if (numM == 0) return numN + 1;
//     if (numM != 0 && numN == 0) return Ackermann(numM - 1, 1);
//     if (numM > 0 && numN > 0) return Ackermann(numM - 1, Ackermann(numM, numN - 1));
// return Ackermann(m, n);
// }