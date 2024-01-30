// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// Функция - генерация одномерного массива из случайных целых чисел
int[] CreateRandomArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

// Функция - переворот элементов массива с помощью рекурсии
int[] GetInvertedArray(int[] array, int index, int[] invertedArray)
{
    if (index < array.Length)
    {
        invertedArray[index] = array[array.Length - 1 - index];
        index++;
        GetInvertedArray(array, index, invertedArray);
    }
    return invertedArray;
}

// Ввод данных
Console.Clear();
Console.Write($"Введите число больше 0: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = CreateRandomArray(number);
int index = 0;
int[] invertedArray = new int[number];
invertedArray = GetInvertedArray(array, index, invertedArray);
Console.WriteLine($"Сгенерированный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Перевернутый массив: [{string.Join(", ", invertedArray)}]");