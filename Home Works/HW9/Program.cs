// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

/*
void ShowNumbers (int n,int m)
{
    if (m!=n)
    {
        if (n > m) 
        {
            ShowNumbers (n-1,m);
            Console.Write(n + " ");
        }
        if (m > n)
        {
            ShowNumbers (m-1,n);
            Console.Write(m + " ");
        }
    }
    else
        Console.Write(n + " ");    
}

Console.Write("Введите первое значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(m,n);
*/


// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int FindSum (int m,int n)
{
    if (m != n)
    {
        if (m > n)
        {
            return FindSum (m-1,n) + m;
        }
        else
        {
            return FindSum (m,n-1) + n;
        }
    }
    return n;
}

Console.Write("Введите первое значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindSum(m,n));
*/

/*
// Задача 68: Напишите программу вычисления
// функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int FunctionAccermana (int m,int n)
{
    if (m==0) return n+1;
    if (m > 0 && n==0) return FunctionAccermana (m-1,1);
    if (m > 0 && n > 0) return FunctionAccermana (m-1,FunctionAccermana (m,n-1));
    else return n+1;               
}

Console.Write("Введите первое значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FunctionAccermana(m,n));
*/