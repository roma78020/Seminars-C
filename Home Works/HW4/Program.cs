﻿/*
//Задача 25: Напишите цикл, который принимает
//на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void Exponentiation (int A,int B)
{
        int degree = 1;
        int result = 1;

        for (int i = 1; i <= B; i++)
        {
            degree = result * A;
            result = degree ;
        }
        Console.WriteLine ($"Число {A} в степени {B} = {result}");
}

Console.Write ("Введите число : ");
int A = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите степень в которую возвести: ");
int B = Convert.ToInt32 (Console.ReadLine());

Exponentiation(A,B);
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int FindSumDigits (int number)
{
    int ostatok = 0;
    int sum = 0;
    while (number > 0)
    {
        ostatok = number % 10;
        sum = sum + ostatok;
        number = number / 10;
    }
    return sum ;
}

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ($"Сумма цифр в числе {number} = {FindSumDigits (number)}");

*/

/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] CreateRandomArray(int size)
{
    int[] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        
    }
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

int[] myArray = CreateRandomArray (a);
ShowArray(myArray);

*/