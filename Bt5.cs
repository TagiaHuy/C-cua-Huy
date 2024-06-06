using System;

public class Baitap5 {
    // public static void Main(string[] args) {
    //     Console.Write("ban muon chay bai 5 phan nao (a, b) : ");
    //     char r;
    //     r = char.Parse(Console.ReadLine());
    //     switch (r) {
    //         case 'a':
    //             MinMax();
    //             break;
    //         case 'b':
    //             SumArray();
    //             break;
    //         default:
    //             Console.WriteLine("Lua chon khong hop le!");
    //             break;
    //     }
    // }

    public static void MinMax() {
        int n = 0;
        Console.Write("Nhap so phan tu cua mang: ");
        n = int.Parse(Console.ReadLine());
        float[] numbers = new float[n]; // Mang 5 phan tu kieu long (8 bytes)

        for (int i = 0; i < numbers.Length; i++)
        {
            do
            {
                try
                {
                    Console.Write("Nhap so thu {0}: ", i + 1);
                    numbers[i] = float.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                    continue;
                }
            } while (float.IsNaN(numbers[i]));
        }
        
        float max = numbers[0], min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max) max = numbers[i];
            if (numbers[i] < min) min = numbers[i];            
        }

        Console.WriteLine("Max: {0}", max);
        Console.WriteLine("Min: {0}", min);
    }

    public static void SumArray() {
        int n = 0;
        Console.Write("Nhap so phan tu cua mang: ");
        n = int.Parse(Console.ReadLine());
        float[] numbers = new float[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            do
            {
                try
                {
                    Console.Write("Nhap so thu {0}: ", i + 1);
                    numbers[i] = float.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                    continue;
                }
            } while (float.IsNaN(numbers[i]));
        }
        
        float sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("Tong cua mang: {0}", sum);
    }
}