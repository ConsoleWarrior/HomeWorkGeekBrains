//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные
//числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintRangeFromMtoN(int numM, int numN)
{
    if (numM > numN)
    {
        PrintRangeFromMtoN(numM - 1, numN);
        System.Console.Write(numM + ",");
    }
    else if (numM < numN)
    {
        PrintRangeFromMtoN(numN - 1, numM);
        System.Console.Write(numN + ",");
    }
    else System.Console.Write(numM + ",");
}
System.Console.WriteLine("Задача 1. Введите числа N и M поочереди");
PrintRangeFromMtoN(Convert.ToInt32(System.Console.ReadLine()),
Convert.ToInt32(System.Console.ReadLine()));

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

int AcermanFunc(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AcermanFunc(n - 1, 1);
    else return AcermanFunc(n - 1, AcermanFunc(n, m - 1));
}
System.Console.WriteLine("Задача 2. Введите числа N и M поочереди");
System.Console.WriteLine(AcermanFunc(Convert.ToInt32(System.Console.ReadLine()),
Convert.ToInt32(System.Console.ReadLine())));

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] CreateAndFillArray(int length)
{
    int[] arr = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rand.Next(0, 100);
        System.Console.Write(arr[i] + "/");
    }
    return arr;
}
void PrintArrayFromEnd(int[] arr, int count)
{
    if (count > 0)
    {
        System.Console.Write(arr[count - 1] + "*");
        PrintArrayFromEnd(arr, count - 1);
    }
}
int[] array = CreateAndFillArray(10);
System.Console.WriteLine();
PrintArrayFromEnd(array, array.Length);