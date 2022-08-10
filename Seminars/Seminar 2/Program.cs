/*
//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindBiggestDigit(int number)  //строка описания метода (функции)
{
    int ed = number % 10;  //ed - единицы
    int dec = number / 10; // dec- десятки
    int max;

    if (ed > dec)
    {
        max = ed;
    }
    else
    {
        max = dec;
    }
    return max;
}

Console.Write("Случайное двузначное число ");
int randomNumber = new Random().Next(10,100); // верхнее число берет на единицу меньше.

int biggestDigit = FindBiggestDigit(randomNumber); //вызываем метод
Console.WriteLine($"Большим числом из {randomNumber} будет {biggestDigit}");

*/

/*
//Задача 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int CutNumber(int number)
{
    int ed = number %10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;
}

int randomNumber = new Random().Next(100,1000);

int newNumber = CutNumber(randomNumber);
Console.WriteLine($"Новая версия числа {randomNumber} будет {newNumber}");
*/

/*
//Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

void IsDivisionable(int num1, int num2)

{
    int reminder = num2 %num1;

    if(num2 % num1 == 0)
    {
        Console.WriteLine($"{num2} is divisionable of {num1}");
    }
    else
    {
        Console.WriteLine($"{num2} is notdivisionable of {num1}. Reminder is {reminder}");
    }
}

Console.Write ("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

IsDivisionable(n1,n2);
*/

/*
//Задача 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool IsDivis(int number)
{
    if(number % 7 == 0 && number % 23 == 0) // return number % 7 == 0 && number % 23 == 0
        return true;
    else
        return false;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

bool isDivison = IsDivis(n);
Console.WriteLine(isDivison);
*/
