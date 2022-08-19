 // Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Первое число {numberA} больше чем второе {numberB} ");
}
else
{
    Console.WriteLine($"Второе число {numberB} больше чем первое {numberA} ");
}
//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 числа: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number2 > max);
{
    number2 = max;
}
if (number3 > max);
{
    max = number3;
}
Console.WriteLine($"Максмальное число из введённых -> {max} ");



