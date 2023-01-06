// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите первое число треугольника:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число треугольника:");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число треугольника:");
int num3 = int.Parse(Console.ReadLine()!);

GetTriangle(num1, num2, num3);

void GetTriangle(int a, int b, int c)
{

if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Yes.");
    }
    else
    {
        Console.WriteLine("no");
    }
}