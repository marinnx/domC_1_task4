// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number3 = int.Parse(Console.ReadLine());
int maxm = number2;
if (number1 > maxm) 
{
    maxm = number1;
}
if (number3 > maxm) 
{
    maxm = number3;
}

Console.WriteLine($"max = {maxm}");