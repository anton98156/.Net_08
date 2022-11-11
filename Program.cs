/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
int rows = 3;
int columns = 4;
int [,] array = GetArray(rows, columns, 0, 9);
Console.WriteLine($"Изначальный массив: ");
PrintArray(array);

Console.WriteLine($"Отсортированный массив: ");
SortedArray(array);
PrintArray(array);

void SortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int [,] GetArray (int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
int rows = 4;
int columns = 3;
int [,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

int [,] GetArray (int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int SUM1(int [,] array){
    int result = (array[0,0] + array[0,1] + array[0,2]);
    return result;
}
Console.WriteLine ($"Сумма строки 1 = {SUM1 (array)}");

int SUM2(int [,] array){
    int result = (array[1,0] + array[1,1] + array[1,2]);
    return result;
}
Console.WriteLine ($"Сумма строки 2 = {SUM2 (array)}");

int SUM3(int [,] array){
    int result = (array[2,0] + array[2,1] + array[2,2]);
    return result;
}
Console.WriteLine ($"Сумма строки 3 = {SUM3 (array)}");

int SUM4(int [,] array){
    int result = (array[3,0] + array[3,1] + array[3,2]);
    return result;
}
Console.WriteLine ($"Сумма строки 4 = {SUM4 (array)}");

if(SUM1 (array) < SUM2 (array) && SUM1 (array) < SUM3 (array) && SUM1 (array) < SUM4 (array)) {
    Console.WriteLine ($"номер строки с наименьшей суммой элементов: 1");
}

else if(SUM2 (array) < SUM1 (array) && SUM2 (array) < SUM3 (array) && SUM2 (array) < SUM4 (array)) {
    Console.WriteLine ($"номер строки с наименьшей суммой элементов: 2");
}

else if(SUM3 (array) < SUM1 (array) && SUM3 (array) < SUM2 (array) && SUM3 (array) < SUM4 (array)) {
    Console.WriteLine ($"номер строки с наименьшей суммой элементов: 3");
}

else if(SUM4 (array) < SUM1 (array) && SUM4 (array) < SUM2 (array) && SUM4 (array) < SUM3(array)){
    Console.WriteLine ($"номер строки с наименьшей суммой элементов: 4");
}

*/


/*
Задача 58: Задайте две квадратные матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*

Console.Clear();

Console.WriteLine("Введите размерности матриц: ");
int m = GetNumbers("Введите кол-во строк в матрицах: ");
int n = GetNumbers("Введите кол-во столбцов в матрицах: ");
int range = 10;

int[,] FirstMatrix = new int[m, n];
GetArray(FirstMatrix);
Console.WriteLine("Матрица 1: ");
PrintArray(FirstMatrix);

int[,] SecondMatrix = new int[m, n];
GetArray(SecondMatrix);
Console.WriteLine("Матрица 2: ");
PrintArray(SecondMatrix);

int[,] FinalMatrix = new int[m, n];
Multiply(FirstMatrix, SecondMatrix, FinalMatrix);
Console.WriteLine("Произведение матриц: ");
PrintArray(FinalMatrix);

void Multiply(int[,] FirstMatrix, int[,] SecondMatrix, int[,] FinalMatrix)
{
    for (int i = 0; i < FinalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FinalMatrix.GetLength(1); j++)
        {
            int res = 0;
            for (int k = 0; k < FirstMatrix.GetLength(1); k++)
            {
                res = res + FirstMatrix[i,k] * SecondMatrix[k,j];
            }
            FinalMatrix[i,j] = res;
        }
    }
}

int GetNumbers(string Num){
    Console.WriteLine(Num);
    int Get = Convert.ToInt32(Console.ReadLine());
    return Get;
}

void GetArray (int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(range);
        }
    }
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

*/

// Seminar 09

/*
**Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

/*
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(M, N));

string PrintNumbers(int start, int end){
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}
*/

/*
**Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12
45 -> 9
*/

/*
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N));

int PrintNumbers(int N){
    if(N == 0) return (0);
    return (N % 10 + PrintNumbers(N / 10));
}
*/

/*
**Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

/*
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (N == 0){
    Console.WriteLine("1");
}
else{
    Console.WriteLine(PrintNumbers(M, N));
}

int PrintNumbers(int M, int N){
    if (N == 0) return 1;
    return (PrintNumbers(M, N - 1) * M);
}
*/