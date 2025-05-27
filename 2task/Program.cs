using System;
using static System.Console;

public class MaxElem
{

    public static void Main(string[] args)
    {
        int[] numbers = GetRandomArray();

        PrintArray(numbers);

        int maxNumber = GetSum(numbers);
        WriteLine("Ответ: " + maxNumber);
    }
    public static void PrintArray(int[] numbers)
    {
        WriteLine();
        foreach (int item in numbers)
        {
            Write(item + " ");
        }
        WriteLine();
    }

    public static int[] GetRandomArray()
    {
        WriteLine("Введите число рандомных значений");
        int number = Convert.ToInt32(ReadLine());

        Random rnd = new Random();

        int[] numbers = new int[number];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(-1000, 1000);
        }

        return numbers;
    }
    public static int GetSum(int[] numbers)
    {
        int sum = 0;

        for(int i = 0; i < numbers.Length;i++)
        {
            if (numbers[i] % 2 == 0)
            {
                sum += numbers[i];
            }
        }

        return sum;
    }
}


