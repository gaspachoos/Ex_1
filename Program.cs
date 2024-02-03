int FindDigits(int m, int n)
{
    int start = m;
    int finish = n;
    if (m > n)
    {
        start = n;
        finish = m;
        Console.WriteLine("Вы ввели стартовое значение больше чем финальное,программа поменяла их местами: ");
    }

    if (start == finish)
    {
        Console.WriteLine();
        Console.WriteLine($"Рекурсия остановилась достигнув финального значения {finish}");
        return start;
    }
    Console.Write($"{start} ");
    FindDigits(start + 1, finish);
    return start;

}