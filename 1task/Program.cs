using System;
using static System.Console;

public class MaxElem 
{

    public static void Main(string[] args)
    {
        int[] numbers = GetRandomArray();

        PrintArray(numbers);

        int maxNumber = GetMax(numbers);
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

    public static int GetMax(int[] array)
    {
        int maxNumber = array[0];
        int minNumber = array[0];

        for (int i = 0; i < array.Length;i++)
        {
            if(maxNumber < array[i])
            {
                maxNumber = array[i];
            }

            if (minNumber > array[i])
            {
                minNumber = array[i];
            }
        }

        WriteLine($"Максимальный: {maxNumber}, Минимальный: {minNumber}");

        return maxNumber;
    }
}


