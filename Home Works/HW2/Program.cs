/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int FindSecondDigit(int number)
{
    int dec = (number % 100) / 10;
    return dec;
}

Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit = FindSecondDigit(number);

Console.WriteLine ($"Вторая цифра числа {number} это {SecondDigit}");
*/

