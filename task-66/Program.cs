// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());


int SumNumbers(int start, int end)
{
    if (start > end)
    {
        int temp = start;
        start = end;
        end = temp;
    }
    if (start == end)
    {
        return start;
    }
    return (start + SumNumbers(start + 1, end));
}


Console.WriteLine("Сумма элементов в промежутке от M до N = " + SumNumbers(m, n));