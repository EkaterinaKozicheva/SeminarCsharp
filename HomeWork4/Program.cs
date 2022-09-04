//===========Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числоЫ b: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;

for (int i = 1; i < b; i++)
{
    res = res*a;
}
Console.WriteLine("A в степени B равно: " + res);


//===========Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(i > 0)
{
    int num  = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine(" Сумма всех цифр в числе:"  + sum);


//===========Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void InitialArray(int[] arr)
{
     string line = String.Empty;
    int B = arr.Length - 1;
    for (int i=0; i<B; i++)
    {
        arr[i] = new Random().Next(1, 100);
        line = line + ($"{arr[i]}, ");
    }
    arr[B] = new Random().Next(1, 100);
    line = line + ($"{arr[B]}");
    Console.Write(line + " -> [" + line + "]");
}
int[] inputarr = new int[8];
InitialArray(inputarr);




