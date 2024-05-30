using System;

namespace obj
{
    public static class Baitapvn
    {
        public static void Main(string[] args)
        {
            Exercises1();
            Exercises2();
            Exercises3();
            Exercises4();
        }
        public static void Exercises1()
        {
            Console.WriteLine("Enter an integer: ");
            int i = int.Parse(Console.ReadLine());

            double doubleNumber = (double)i;
            Console.WriteLine($"The number you entered is {i} and as double is {doubleNumber}");
        }

        public static void Exercises2()
        {
            Console.WriteLine("Enter a real number: ");
            double realNumber = double.Parse(Console.ReadLine());
            int intNumber = (int) realNumber;
            long longNumber = (long) realNumber;
            Console.WriteLine($"The number you entered is {realNumber} and as long is {longNumber} and as int is {intNumber}");
        }

        public static void Exercises3()
        {
            Console.WriteLine("Enter a character: ");
            char character = Console.ReadKey().KeyChar;
            int asciiCode = (int)character;
            Console.WriteLine($"\nThe character you entered is '{character}', its ASCII code is {asciiCode}");
        }

        public static void Exercises4()
        {
            int[] numbers;
            int arrayLength;

            Console.WriteLine("Enter the length of the array: ");
            arrayLength = int.Parse(Console.ReadLine());
            numbers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Enter the value of element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxValue = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }

            Console.WriteLine($"The maximum value in the array is: {maxValue}");
        }
    }
}