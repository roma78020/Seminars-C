// Задача 1
// Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)

// int [] ReverseArray (int [] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i]= temp;
//     }

//     return array;
// }

//Тоже самое

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
int [] ReverseArray (int [] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j]= temp;
    }

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
ShowArray(ReverseArray(myArray));

*/

// Задача 2
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли 
// существовать треугольник с сторонами такой
// длины.
// a < b + c

/*
bool FindNoName (int a,int b,int c)
{
    if (a < b + c && b < a + c && c< a + b) 
    return true;
    else return false;
}
Console.Write ("Введите длину a: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите длину b: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите длину с: ");
int c = Convert.ToInt32 (Console.ReadLine());

FindNoName (a,b,c);

if (FindNoName(a,b,c)) Console.WriteLine ("треугольник");
else Console.WriteLine ("Не треугольник");
*/

// Задача 3.
//Не используя рекурсию, выведите первые N
//чисел Фибоначчи. Первые два числа Фибоначчи:
//a и b.

/*
void Fibonacci (int n, int a, int b)
{
    int c = 0;
    Console.Write (a+" "+b+" ");

    for (int i = 2; i < n; i++)
    {
        c= a+b;
        Console.Write (c+" ");
        a=b;
        b=c;
    }
}

Console.Write ("Введите длину чисел N: ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите первое число a: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число b: ");
int b = Convert.ToInt32 (Console.ReadLine());

Fibonacci(n,a,b);
*/

// Задача 4.
//Напишите программу, которая будет
//преобразовывать десятичное число в двоичное.

void Converter (int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /=2;     //number = number /2 
    }
    Console.WriteLine(result);
}

Console.Write ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine());

Converter(num);
