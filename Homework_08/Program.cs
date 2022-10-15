// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите кол-во строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите кол-во столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 1, 15);
// PrintArray(array);
// Console.WriteLine();
// ReversedRowsArray(array);
// PrintArray(array);

// void ReversedRowsArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int[] newarray = new int[array.GetLength(1)];
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             newarray[j] = array[i, j];
//         }
//         Array.Sort(newarray);
//         Array.Reverse(newarray);
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = newarray[j];
//         }
//     }
// }

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] array = GetArray(5, 4, 0, 20);
// PrintArray(array);
// Console.WriteLine("Сумма значений в строках: ");
// SumRows(array);

// void SumRows(int[,] array)
// {
//     int sum = 0;
//     int min = 10000;
//     int row = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (sum < min)
//         {
//             min = sum;
//             row = i + 1;
//         }
//         Console.WriteLine($"{sum}\t");
//         sum = 0;
//     }
//     Console.WriteLine($"Минимальная сумма значений '{min}' находится на  '{row}' строке.");
//     Console.WriteLine();
// }


//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] array = GetArray(2, 2, 1, 10);
// PrintArray(array);
// Console.WriteLine();
// int[,] array2 = GetArray(2, 2, 1, 10);
// PrintArray(array2);
// Console.WriteLine("Произведение двух матриц:");
// int[,]matrix = GetNewMatrix(array, array2);
// PrintArray(matrix);

// int[,] GetNewMatrix(int[,] array, int[,] array2)
// {
//     int[,] matrix = new int[array.GetLength(0), array2.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             for (int l = 0; l < array2.GetLength(0); l++)
//             {
//                 matrix[i, j] += array[i, l] * array2[l, j];
//             }
//         }
//     }
//     return matrix;
// }


//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)

// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array = Get3DArray(2, 2, 2);
// Print3DArray(array);


// int[,,] Get3DArray(int m, int n, int k)
// {
//     int count = 15;
//     int[,,] result = new int[m, n, k];
//     for (int z = 0; z < m; z++)
//     {
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < k; j++)
//             {
//                 result[z, i, j] = count;
//                 count = count + 4;
//             }
//         }
//     }
//     return result;
// }

// void Print3DArray(int[,,] array)
// {
//     for (int z = 0; z < array.GetLength(0); z++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             for (int j = 0; j < array.GetLength(2); j++)
//             {
//                 Console.Write($"{array[z, i, j]}({z},{i},{j}) \t");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }


//Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int N=4;
// int num =1;
// int[,] array = SpiralMatrix(N, N);

// for ( int round =0; round<N-1;round ++)
// {
// for(int i =0+round; i<N-round;i++)
// {
//     array[0+round,i]=num;
//     num++;
// }
// num--;
// for(int i =0+round; i<N-round;i++)
// {
//     array[i,N-1-round]=num;
//     num++;
// }
// num--;
// for(int i =N-1-round; i>=0 + round;i--)
// {
//     array[N-1-round,i]=num;
//     num++;
// }
// num--;
// for(int i =N-1-round; i>=1+round;i--)
// {
//     array[i,0+round]=num;
//     num++;
// }
// }
// PrintArray(array);

int[,] SpiralMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = 0;
        }
    }
    return matrix;
}

int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(MinValue, MaxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}