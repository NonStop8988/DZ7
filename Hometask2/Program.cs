// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Функция - вычисление функции Аккермана с помощью рекурсии
int GetResultAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return GetResultAckermann(m - 1, 1);
    }

    return GetResultAckermann(m - 1, GetResultAckermann(m, n - 1));
}

// Ввод данных
Console.Clear();
while(true)
{
    Console.Write($"Введите неотрицательное число в качестве значения 'm': ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write($"Введите неотрицательное число в качестве значения 'n': ");
    int n = int.Parse(Console.ReadLine()!);

    if (m < 0 || n < 0)
    {
        Console.WriteLine($"Вы ввели отрицательное число");
        continue;
    }
    
    int result = GetResultAckermann(m, n);
    Console.WriteLine($"Результат вычисления функции Аккермана = {result}");
    break;
}