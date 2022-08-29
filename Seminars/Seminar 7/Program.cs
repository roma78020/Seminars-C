//Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.

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

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);

/*

// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится
// по формуле: Aij = i+j. Выведите полученный массив
// на экран.

int[,] Create2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = i + j;

    return newArray;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(m, n);
Show2dArray(myArray);

*/

/*
// Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

int[,] FindEven (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i= i+2)
    {
        
        for (int j = 0; j < array.GetLength(1); j=j+2)
        {
            array[i,j] *= array [i,j];
        }
    }
    return array;
}

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
int [,] newArray = FindEven(myArray);
Console.WriteLine();
Show2dArray(newArray);
*/

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.)


int FindSum (int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        sum = sum + array [i,i];

    return sum;
}

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.Write(FindSum (myArray));

