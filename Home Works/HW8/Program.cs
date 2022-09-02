// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] FindSumNumbers(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
        Console.Write($"Сумма {i+1} строки = {sum[i]} ");
        Console.WriteLine();

    }
    return sum;

}

void MinRows(int[] array)
{
    int min =array[0];
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {       
        if (array[i] <= min)
        {  
            min = array[i];          
            count = i+1;
        }        
    }
    Console.WriteLine($"Минимальная сумма в строке {count}");
    
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
int [] newArray = FindSumNumbers(myArray);
MinRows(newArray);
*/



// Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Sortirovka (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                int temp = 0;
                if (array[i,j]<array[i,j+1])
                {
                   temp = array[i,j];
                   array[i,j] = array[i,j+1];
                   array[i,j+1]= temp;  
                }
            }
        }
    }
    return array;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
int[,] newArray = Sortirovka(myArray);
Console.WriteLine("Отсортированный по убыванию массив:");
Show2dArray(newArray);

*/

/*
// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrix (int [,] arrayA , int[,] arrayB)
{   
    int[,] newArray = new int [arrayA.GetLength(0),arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                newArray[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }
    return newArray;
}


Console.Write("Введите количество строк матрицы А: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы В: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы В: ");
int b = Convert.ToInt32(Console.ReadLine());
if (m == b) 
{
    Console.Write("Введите минимальное число массива: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число массива: ");
    int max = Convert.ToInt32(Console.ReadLine());


    int[,] myArray = CreateRandom2dArray(m, n, min, max);
    Console.WriteLine("Матрица А:");
    Show2dArray(myArray);
    int[,] myArray2 = CreateRandom2dArray(a, b, min, max);
    Console.WriteLine("Матрица В:");
    Show2dArray(myArray2);

    Console.WriteLine("Матрица АВ:");
    int[,] newArray = ProductMatrix (myArray,myArray2);
    Show2dArray(newArray);
}
else Console.WriteLine("Матрицы перемножить нельзя");

*/


