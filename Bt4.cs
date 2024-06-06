using System;

public class Baitap4 {
    public static void Main(string[] args) {
        Console.Write("ban muon chay bai 4 phan nao (a, b) : ");
        char r;
        r = char.Parse(Console.ReadLine());
        switch (r) {
            case 'a':
                Palindrome();
                break;
            case 'b':
                SumLongArray();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                break;
        }
    }

    public static void Palindrome() {
        ulong number = 0; // mang ulong (8 bytes)

        do
        {
            try
            {
                Console.Write("Nhap so nguyen khong dau 8 bytes ");
                number = ulong.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                continue;
            }
        } while (number < 0 || number > ulong.MaxValue);

        string numberStr = number.ToString();
        int length = numberStr.Length;

        bool isPalindrome = true;
        for (int i = 0; i < length / 2; i++)
        {
            if (numberStr[i]!= numberStr[length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        Console.WriteLine(isPalindrome ? "{0} la so Palindrome" : "{0} khong phai so Palindrome ", number);
    }

    public static void SumLongArray() {
        int n = 0;
        Console.Write("Nhap so phan tu cua mang: ");
        n = int.Parse(Console.ReadLine());
        long[] numbers = new long[n]; // Mang 5 phan tu kieu long (8 bytes)

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
            } while (numbers[i] < long.MinValue || numbers[i] > long.MaxValue);
        }
        
        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Tong cac so trong mang la: {0}", sum);
    }

}