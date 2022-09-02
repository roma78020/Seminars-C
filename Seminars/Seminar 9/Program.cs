// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа
// в промежутке от 1 до N.

// void ShowNumbers(int n)
// {
//     if (n > 1) ShowNumbers(n-1); // вызываем метод для 9 и т.д.
    
//     Console.Write(n + " ");
// }

// ShowNumbers(10); //от 1 до 10 выведет

// void ShowNumbers(int n)
// {
//     if (n >= 1) 
//     {
//         Console.Write(n + " ");
//     }
//     ShowNumbers(n-1);

// }

// ShowNumbers(10);  // от 10 до 1 выведет



// Напишите программу, которая будет
// принимать на вход число и возвращать
// сумму его цифр.

// int FindSum (int n) 
// {
//     if (n > 0)
//         return FindSum(n / 10) + n % 10;
//     else    
//         return n;
// }

// Console.WriteLine(FindSum(123));

// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа
// в промежутке от M до N.

// void ShowNumbers (int n,int m)
// {
//     if (m!=n)
//     {
//         if (n > m) 
//         {
//             ShowNumbers (n-1,m);
//             Console.Write(n + " ");
//         }
//         if (m > n)
//         {
//             ShowNumbers (m-1,n);
//             Console.Write(m + " ");
//         }
//     }
//     else
//         Console.WriteLine(n + " ");    
// }

// ShowNumbers(5,20);




// Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А в целую
// степень B с помощью рекурсии.

int NumberPower (int a, int b)
{
    if (b != 0)
    {
        return NumberPower(a,b-1) * a;
    }
    else return 1;
}

Console.WriteLine(NumberPower(2,3));
