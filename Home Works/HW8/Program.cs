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

// int[] FindSumNumbers(int[,] array)
// {
//     int[] sum = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum[i] += array[i, j];
//         }
//         Console.Write($"Сумма {i+1} строки = {sum[i]} ");
//         Console.WriteLine();

//     }
//     return sum;

// }

// void MinRows(int[] array)
// {
//     int min =array[0];
//     int count =0;
//     for (int i = 0; i < array.Length; i++)
//     {       
//         if (array[i] <= min)
//         {  
//             min = array[i];          
//             count = i+1;
//         }        
//     }
//     Console.WriteLine($"Минимальная сумма в строке {count}");
    
// }

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
// int [] newArray = FindSumNumbers(myArray);
// MinRows(newArray);



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



int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
int[,] newArray = Sortirovka(myArray);
Console.WriteLine("Отсортированный по убыванию массив:");
Show2dArray(newArray);

*/