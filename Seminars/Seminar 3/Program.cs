/*
//Задача 1.
//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return 0; //выведет номер четверти 0 - что будет говорить о том,
              //что ни одно из условий не выполнилось
}

Console.Write ("Введите первое число: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
double yA = Convert.ToInt32(Console.ReadLine());

int Quart = FindQuart(xA,yA); //вызываем метод

if(Quart == 0)
    Console.WriteLine ("Точка находится на осях!");
else
    Console.WriteLine($"Эта точка нахотся в {Quart} четверти");

*/

//Задача 2.
//Напишите программу,которая по заданному номеру 
//четверти, показывает диапазон возможных координат
//точек в этой четверти (x и y).


/*
void FindCoordinates(int number)
{
    if(number == 1) Console.WriteLine ("Возможные координаты: Х+ ,У+");
    if(number == 2) Console.WriteLine ("Возможные координаты: Х- ,У+");
    if(number == 3) Console.WriteLine ("Возможные координаты: Х- ,У-");
    if(number == 4) Console.WriteLine ("Возможные координаты: Х+ ,У-");
}

Console.Write ("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0 || number > 4)
    Console.WriteLine ("Неверно указан номер четверти");
else
    FindCoordinates(number);
*/


//Задача 3.
//Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между
//ними в 2D пространстве.


/*
double FindQuartDistance(double Xa, double Ya, double Xb, double Yb)
{
    double AB = Math.Pow(Xb-Xa, 2)+ Math.Pow(Yb-Ya, 2);
    double lenght = Math.Sqrt (AB);
    return lenght;
}

Console.Write ("Введите координату Х первой точки: ");
double Xa = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату У первой точки: ");
double Ya = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату Х второй точки: ");
double Xb = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату У второй точки: ");
double Yb = Convert.ToInt32(Console.ReadLine());

double QuartDistance = FindQuartDistance (Xa,Ya,Xb,Yb);

Console.WriteLine($"Расстояние между точками равно {QuartDistance}");
*/

/*
//Задача 4.
//Напишите программу, которая принимает на вход число (N)
//и выдаёт на консоль квадраты чисел от 1 до N.


void SquareNumber (int number)
{
    int count = 1;
    while (count <= number)
    {
        int num = count * count;
        Console.WriteLine ($"Квадрат числа {count} = {num}");
        count++;
    }
    
}

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

SquareNumber(number);

*/