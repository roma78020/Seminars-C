// Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] CreateRandomArray(int a, int minValue, int maxValue)
{
    int[] newArray = new int [a]; // int[]- массив

    for (int i = 0; i < a; i++)
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
int FindEvenNumbers (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}



Console.Write ("Введите длину массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Количество четных чисел в массиве = {FindEvenNumbers (myArray)}");
*/

