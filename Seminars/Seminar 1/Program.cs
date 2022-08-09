//Задача 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); //запрос числа от пользователя

int quad = num * num;

Console.WriteLine("Квадрат числа " + num + " это " + quad);

Console.WriteLine($"Квадрат числа {num} это {quad}"); // 6 и 8 строка - одно и тоже
*/

/*
// Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write ("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (n1 == quad2)
{
    Console.WriteLine($"{n1} является квадратом {n2}");
}
else
{
    Console.WriteLine($"{n1} не является квадратом {n2}");
}
*/

//Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Write ("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);

while (current <= number )
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
/*
123 % 10 -> 3
524 % 10 -> 4
745 % 10 -> 5

123 % 100 -> 23
524 % 100 -> 24
745 % 100 -> 45

123 / 100 -> 1
524 / 100 -> 5
745 / 100 -> 7

123 / 10 -> 12
524 / 10 -> 52
745 / 10 -> 74
*/
/*
Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ed = number % 10;

Console.WriteLine ($"Последняя цифра числа {number} это {ed}");
*/