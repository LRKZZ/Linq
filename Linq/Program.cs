using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] mass = { -2, -5, 0, 5, 7, 9, 10, 12, 31 };
        var negativeNums = mass.Count(x => x < 0);
        var positiveNums = mass.Count(x => x > 0);
        var evenSum = mass.Where(x => x % 2 == 0).Sum();

        Console.WriteLine($"Кол-во отрицательных: {negativeNums}");
        Console.WriteLine($"Кол-во положительных: {positiveNums}");
        Console.WriteLine($"Сумма чётных: {evenSum}");
    }
}
