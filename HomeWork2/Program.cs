//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int a = num % 100 / 10;
Console.WriteLine($"Вторая цифра трёхзначного числа {num} -> {a} ");

//Задача 13. Напишите программу, которая которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
string numOther = Convert.ToString(num);

if(numOther.Length > 2) {
    Console.WriteLine($"Третья цифра: {numOther[2]} ");
}
else 
{

    Console.WriteLine($"Третьей цифры нет ");
}


//  Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число номера дня недели: ");
int num = int.Parse(Console.ReadLine());

if(num < 6 && num < 7)
{
    Console.WriteLine($"Будний день ");
}
else
{
    Console.WriteLine($"Выходной день ");
}
