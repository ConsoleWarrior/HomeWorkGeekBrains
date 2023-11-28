void FillAndPrintArray(int[] arr) //заполняем и печатаем массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
        System.Console.Write("/ " + arr[i] + " /");
    }
    System.Console.WriteLine();
}
void FillAndPrintArrayDouble(double[] arr) //заполняем и печатаем массив double
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (double)new Random().Next(0, 10000) / 100;
        System.Console.Write("/ " + arr[i] + " /");
    }
    System.Console.WriteLine();
}


//// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения
// которых лежат в отрезке [20,90].

// int[] array = new int[10];
// FillAndPrintArray(array);
// int count = 0;
// foreach (int item in array)
// {
//     if (item > 20 & item < 90) count++;
// }
// System.Console.WriteLine("В отрезке [20,90]: " + count + " элементов");

//// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество 
// чётных чисел в массиве.

// int[] array = new int[10];
// FillAndPrintArray(array);
// int count = 0;
// foreach (int item in array)
// {
//     if (item % 2 == 0) count++;
// }
// System.Console.WriteLine("Четных: " + count + " элементов");

//// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и 
// минимальным элементов массива.

// double[] array = new double[10];
// FillAndPrintArrayDouble(array);
// double min = array[0], max = array[0];
// foreach (double item in array)
// {
//     if (item > max) max = item;
//     if (item < min) min = item;
// }
// System.Console.WriteLine($"{max} - {min} = {max - min}");

// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из 
// цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

int num = new Random().Next(1, 100000);
System.Console.WriteLine(num);
int temp = num, count = 0;
while (temp > 0)
{
    count++;
    temp /= 10;
}
int[] arr = new int[count];
for (; count > 0; count--)
{
    arr[count - 1] = num % 10;
    num /= 10;
}
foreach(int item in arr)
{
    System.Console.Write(item+"/");
}