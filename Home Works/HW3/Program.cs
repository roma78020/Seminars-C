//Задача 19
//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void FindPalindrome (int number)
{
    if(number%10 == number / 10000 && (number % 100)/10 == (number / 1000)%10)
        Console.WriteLine ($"Число {number} - полиндром");
        else
        Console.WriteLine ($"Число {number} - НЕ полиндром");
    
}

Console.Write ("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999 || number < 10000)
    Console.WriteLine ($"Число {number} не является пятизначным");
else
    FindPalindrome (number);
