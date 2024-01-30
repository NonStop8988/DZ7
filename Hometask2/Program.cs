// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Функция - вычисление функции Аккермана с помощью рекурсии
int GetResultAckermann(int m, int n)
{
    int result = n;
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return GetResultAckermann(m - 1, 1);
    }

    if (m > 0 && n > 0)
    {
        return GetResultAckermann(m - 1, GetResultAckermann(m, n - 1));
    }
    result = n;
    return result;
}

// Ввод данных
Console.Clear();
Console.Write($"Введите число в качестве значения 'm': ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число в качестве значения 'n': ");
int n = int.Parse(Console.ReadLine()!);
int result = GetResultAckermann(m, n);
Console.WriteLine($"Результат вычисления функции Аккермана = {result}");