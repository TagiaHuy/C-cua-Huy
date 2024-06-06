using System;

public class Baitap2 {
    public static void Main(string[] args) {
        Console.Write("ban muon chay bai 2 phan nao (a, b, c, d) : ");
        char r;
        r = char.Parse(Console.ReadLine());
        switch (r) {
            case 'a':
                MinMax1Byte();
                break;
            case 'b':
                SumEvenNumbers1Byte();
                break;
            case 'c':
                SumFromOneToN1Byte();
                break;
            case 'd':
                SumDigits1Byte();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                break;
        }
    }

    public static void MinMax1Byte() {
        int s;
        Console.WriteLine("Nhap so luong phan tu: ");
        s = int.Parse(Console.ReadLine());
        sbyte[] numbers = new sbyte[s]; //Mang 5 phan tu kieu sbyte (1 byte)

        for (int i = 0; i < numbers.Length; i++)
        {
            do
            {
                try
                {
                    Console.Write("Nhap so thu {0} : ", i + 1);
                    numbers[i] = sbyte.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                    continue;
                }
            } while (numbers[i] < SByte.MinValue || numbers[i] > SByte.MaxValue);
        }

        sbyte max = numbers[0], min = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max) max = numbers[i];
            if (numbers[i] < min) min = numbers[i];
        }

        Console.WriteLine("Max: {0}", max);
        Console.WriteLine("Min: {0}", min);
    }

    public static void SumEvenNumbers1Byte() {
        int n;
        Console.WriteLine("Nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());
        sbyte[] numbers = new sbyte[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            do
            {
                try
                {
                    Console.Write("Nhap so thu {0} : ", i + 1);
                    numbers[i] = sbyte.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                    continue;
                }
            } while (numbers[i] < SByte.MinValue || numbers[i] > SByte.MaxValue);
        }
    
    int sumEven = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) sumEven += numbers[i];
    }

    Console.WriteLine("Tong cac so chan la: {0}", sumEven);
    }

    public static void SumFromOneToN1Byte() {
        byte n = 0;

        do
        {
            try
            {
                Console.WriteLine("Nhap so nguyen khong dau (toi da 255): ");
                n = byte.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                continue;
            }
        } while (n < 0 || n > SByte.MaxValue);

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Tong cac so tu 1 den {0} la: {1}", n, sum);
    }

    public static void SumDigits1Byte() {
        byte number = 0;
        do
        {
            try
            {
                Console.Write("Nhap so nguyen khong dau (toi da 255) : ");
                number = byte.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                continue;
            }
        } while (number < 0 || number > 255);
        int sumDigits = 0;
        byte temp = number;

        while (temp > 0)
        {
            sumDigits += temp % 10;
            temp /= 10;
        }

        Console.WriteLine("Tong cac chu so cua {0} la: {1}", number, sumDigits);
    }
}