using System;

public class Baitap3 {
    public static void Main(string[] args) {
        Console.Write("ban muon chay bai 3 phan nao (a, b) : ");
        char r;
        r = char.Parse(Console.ReadLine());
        switch (r) {
            case 'a':
                SumUnsignedShortArray();
                break;
            case 'b':
                SumSignedShortArray();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                break;
        }
    }

    public static void SumUnsignedShortArray() {
        int n = 0;
        Console.Write("Nhap so phan tu cua mang: ");
        n = int.Parse(Console.ReadLine());

        ushort[] numbers = new ushort[n]; // mang ushort (2 bytes)

        for (int i = 0; i < numbers.Length; i++)
        {
            do
            {
                try
                {
                    Console.Write("Nhap so thu {0}: ", i + 1);
                    numbers[i] = ushort.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                    continue;
                }
            } while (numbers[i] < 0);
        }
        uint sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Tong cac so trong mang la: {0}", sum);
    }

    public static void SumSignedShortArray() {
        int n = 0;
        Console.Write("Nhap so phan tu cua mang: ");
        n = int.Parse(Console.ReadLine());
        short[] numbers = new short[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            do
            {
                try
                {
                    Console.Write("Nhap so thu {0}: ", i + 1);
                    numbers[i] = short.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                    continue;
                }
            } while (numbers[i] < short.MinValue || numbers[i] > short.MaxValue);
        }
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Tong cac so trong mang la: {0}", sum);
    }
}