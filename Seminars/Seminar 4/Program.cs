/*
//Задача 1.
//Напишите программу, которая принимает
//на вход число (А) и выдаёт сумму 
//чисел от 1 до А.

int FindSum(int number)
{
    int sum = 0;

    for (int current = 1; current <= number; current++)
    {
        sum = sum + current; // sum += current;
    }

    return sum;
}

Console.Write ("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ($"Сумма чисел от 1 до {a} = {FindSum (a)}");
*/

/*
//Задача 2.
//Напишите программу, которая принимает
//на вход число и выдаёт количество цифр
//в числе.

int FindDigits (int number)
{
    int current = 0;
    while (number > 0)
    {
        number = number / 10;
        current++;
    }
    return current ;
}

Console.Write ("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ($"Количество цифр в числе {a} = {FindDigits (a)}");
*/


//Задача 3.
//Напишите программу, которая принимает
//на вход число N и выдаёт произведение
//чисел от 1 до N.

/*
int FindFactorial(int number)
{
    int factorial = 1;

    for (int current = 1; current <= number; current++)
    {
        factorial = current * factorial;
    }

    return factorial;
}

Console.Write ("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ($"Произведение чисел от 1 до {a} = {FindFactorial(a)}");
*/

/*
//Задача 4
//Напишите программу, которая выводит 
//массив из 8 элементов, заполненный 
//нулями и единицами в случайном порядке.

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

Console.Write ("Введите длину массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
*/
