//Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.

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
/*
int[,] ChengeRows (int[,] array, int row1, int row2) //замена строк
{
    if (row1>= array.GetLength(0) || row2 >= array.GetLength(0))
        return array;
    else
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1 , j];
            array[row1, j] = array[row2, j];
            array[row2,j] = temp;
        }
    }
    return array;
}
*/
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
// Console.WriteLine();
// myArray = ChengeRows (myArray, 0 , m-1);
// Show2dArray(myArray);


/*
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы.
// В случае, если это невозможно, программа
// должна вывести сообщение для пользователя.

int [,] ChengeRowsColumns (int [,] array,int rows,int columns)
{
    if (rows != columns)
    {
        Console.WriteLine("Невозможно развернуть");
        return array;
    }
    else
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array [i,j];
            array[i,j] = array [j,i];
            array [j,i] = temp;
        }
    }
    return array;
    }
    
}

myArray = ChengeRowsColumns(myArray, m, n);
Console.WriteLine();
Show2dArray(myArray);
*/


// Из двумерного массива целых чисел
// удалить строку и столбец,на пересечении
// которых расположен наименьший элемент.

int [,] FindMinNumber (int[,] array)
{
    int imin = 0;
    int jmin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j]< array[imin,jmin])
            {
                imin = i;
                jmin = j;
            }
            
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
        array[i,jmin] = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        array[imin,j] = 0;
    
    Console.WriteLine(imin+" "+jmin+" ");
    return array;    
}

myArray = FindMinNumber (myArray);
Console.WriteLine();
Show2dArray(myArray); 



