/*
//Задача 1.
//Задайте массив из 12 элементов, 
//заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.


int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size]; // int[]- массив

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue,maxValue + 1);

        return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

void FindMinMaxSum(int[] array)
{
    int sumPositive = 0; //положительные числа
    int sumNegative = 0; //отрицательные числа

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPositive += array[i];
        else
            sumNegative += array[i];
    }
    Console.WriteLine ($"Сумма положительных элементов {sumPositive}");
    Console.WriteLine ($"Сумма отрицательных элементов {sumNegative}");
}
Console.Write ("Введите длину массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
FindMinMaxSum(myArray);
*/

//Задача 2.
//Напишите программу замены элементов массива:
//положительные элементы замените на соответствующие
//отрицательные, и наоборот.

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size]; // int[]- массив

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue,maxValue + 1);

        return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

/*
int[] ReplacingSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = array [i] * -1;
    return array;
}
Console.Write ("Введите длину массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
int[] newMyArray = ReplacingSign (myArray);
ShowArray(newMyArray);

*/
//Задача 3
//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве.

/*
bool FindNumberArray(int[] array,int num)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num) return true;
    return false;
}
Console.Write ("Введите длину массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите искомое число массива: ");
int num = Convert.ToInt32 (Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine (FindNumberArray(myArray,num));
*/

/*
//Задача 4
//Задайте одномерный массив из 12 случайных чисел.
//Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

int Find (int[] array,int a,int b)
{    
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= a && array[i] <= b)
            count++;

    }
    return count; 
}
Console.Write ("Введите длину массива: ");
int size = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число отрезка: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число отрезка: ");
int b = Convert.ToInt32 (Console.ReadLine());

int[] myArray = CreateRandomArray (size, min, max);
ShowArray(myArray);
Console.WriteLine ($"{Find(myArray,a,b)}");
*/