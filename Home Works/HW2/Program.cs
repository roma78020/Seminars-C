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

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int FindThirdDigit(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    
    return number;
}

Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThreeDigit = FindThirdDigit(number);

if (ThreeDigit <= 99)
    {
        Console.WriteLine ($"У числа {number} нет третьей цифры");
    }
    else
    {
        ThreeDigit = ThreeDigit % 10;
        Console.WriteLine ($"Третья цифра числа {number} это {ThreeDigit}");
    }
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

void FindWeekend (int number)
{
    if (number <= 5) 
    Console.WriteLine ($"{number} день недели не является выходным");
    else 
    Console.WriteLine ($"{number} день недели ВЫХОДНОООЙ!УРААА!");
}

Console.Write ("Введите число дня недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 7)
    FindWeekend(number);
else
    Console.WriteLine ($"Будь внимательней! Число {number} не является днем недели. Повтори попытку и введи число от 1 до 7.>");
*/