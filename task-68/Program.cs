// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите неотрицательное число m");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число n");
int numN = Convert.ToInt32(Console.ReadLine());


int Ackermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
        return -1;
    }
    if (m == 0)
    {
        return n + 1;
    }
    if ((m > 0) && (n == 0))
    {
        return Ackermann(m - 1, 1);
    }
    if ((m > 0) && (n > 0))
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return Ackermann(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел {numM}, {numN} = {Ackermann(numM, numN)}");