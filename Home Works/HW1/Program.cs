/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 == n2)
{
    Console.WriteLine($"Числа равны");
}
else
{
    if (n1 > n2)
    {
        Console.WriteLine($"Число {n1} является большим, а число {n2} - меньшим");
    }
    else
    {
        Console.WriteLine($"Число {n2} является большим, а число {n1} - меньшим");
    }
}
*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.Write($"Максимальное число = {max}");
*/

/*
///Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.Write($"Число {number} - четное");
}
else
{
    Console.Write($"Число {number} - нечетное");
}

*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= number) //если нужно показать все четные не включая N- меняем условие на строго <
{
    if (current%2 == 0) Console.Write(current + " ");
        
current++; 
}

*/