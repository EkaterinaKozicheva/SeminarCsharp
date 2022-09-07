//=============Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] RandomArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void GetArray(int[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"]");
}
void Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел: {count}");
}
int a = new Random().Next(1, 20);
int[] array = RandomArray(a);
GetArray(array);
Console.WriteLine();
Count(array);



//============Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void GetArray(int[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"]");
}
void PrintArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = array[i] + sum;
        }
    }
    Console.WriteLine($"Сумма чисел на нечетных позициях: {sum} ");
}
int size = new Random().Next(1, 20);
int[] array = RandomArray(size);
GetArray(array);
Console.WriteLine();
PrintArray(array);


//===============Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void GetArray(int[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"]");
}
void МахMin(int[] array)
{
    int max = 0;
    int min = 100;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    result = max - min;
    Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}
int size = new Random().Next(2, 20);
int[] array = RandomArray(size);
GetArray(array);
Console.WriteLine();
МахMin(array);