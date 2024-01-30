// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// Функция - рекурсия по выдаче натуральных цифр в промежутке заданных чисел
void PrintNumbersInRange(int start, int end)
{
    if (start > end)
    {
        return;
    }

    if (start == 0)
    {
        start += 1;
    }
    Console.Write($"{start} ");
    PrintNumbersInRange(start + 1, end);
}

// Функция - проверка числа на натуральность
int IsNaturalNumber(int number)
{
    if (number < 0)
    {
        number = 0;
    }
    return number;
}

// Ввод данных
Console.Clear();
Console.Write($"Введите число в качестве значения 'start': ");
int start = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число в качестве значения 'end': ");
int end = int.Parse(Console.ReadLine()!);
int temp = 0;
start = IsNaturalNumber(start);
end = IsNaturalNumber(end);

if (start > end)
{
    temp = start;
    start = end;
    end = temp;
}

if (end > 0)
{
    Console.Write("Натуральные числа в заданном промежутке: ");
    PrintNumbersInRange(start, end);
}
else
{
    Console.Write("Натуральных чисел в заданном промежутке нет");
}
