//=======Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Mirror(int num)
// {
// int a = num / 10000;
// int b = (num % 10000) / 1000;
// int c = (num % 100) / 10;
// int d = num % 10;

// if(a == d && b == c)
//     {
//         Console.WriteLine("Палиндром");
//     }
//     else
//     {
//         Console.WriteLine("Не палиндром");
//     }
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number > 99999 || number < 10000) Console.WriteLine("Число не подходит по условию");
// else Mirror(number);

//========Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Dist (int x1, int y1, int c1, int x2, int y2, int c2)
{
    double d1 = x2 - x1;
    double d2 = y2 - y1;
    double d3 = c2 - c1;
    double D = Math.Sqrt(d1*d1+d2*d2+d3*d3);
    {
        Console.WriteLine($"Расстояние между точками  "  + Math.Round (D, 2));
    }
}
Console.WriteLine("Введите координату x1 первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1 первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату c1 первой точки: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2 второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату  y2 второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату c2 второй точки: ");
int c2 = Convert.ToInt32(Console.ReadLine());

Dist(x1, x2, y1, y2, c1, c2);

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube(int n)
// {
// int x = 1;
// while (x <= n) 
// {
//     Console.Write(x*x*x + ", ");
//     x++;
// }
// }
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num <= 0) Console.WriteLine("Неверный ввод");
// else Cube(num);

