//Задача 19
//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*
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

*/


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double FindQuartDistance(double Xa, double Ya, double Za, double Xb,double Yb, double Zb)
{
    double AB = Math.Pow(Xb-Xa, 2)+ Math.Pow(Yb-Ya, 2)+ Math.Pow(Zb-Za, 2);
    double lenght = Math.Sqrt (AB);
    return lenght;
}

Console.Write ("Введите координату Х первой точки: ");
double Xa = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату У первой точки: ");
double Ya = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату Z первой точки: ");
double Za = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату Х второй точки: ");
double Xb = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату У второй точки: ");
double Yb = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату Z второй точки: ");
double Zb = Convert.ToInt32(Console.ReadLine());

double QuartDistance = FindQuartDistance (Xa,Ya,Za,Xb,Yb,Zb);

Console.WriteLine($"Расстояние между точками равно {QuartDistance}");

*/

/*
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт
//таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void СubeNumber (int number)
{
    int count = 1;
    while (count <= number)
    {
        int num = count * count * count;
        Console.WriteLine ($"Куб числа {count} = {num}");
        count++;
    }
    
}

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

СubeNumber(number);

*/