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
Рекомендованная задача из семинара: 
Отсортировать нечетные столбцы массива по возрастанию, вывести массив изначальный и отсортированный
*/