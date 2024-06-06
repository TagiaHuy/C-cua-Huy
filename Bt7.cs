using System;
public class Baitap7 {
    public static void Main(string[] args) {
        bool n = true;

        while (n)
        {
            try
            {
                Console.Write("ban muon chay bai 7 phan nao (a, b, c, d, e, g, h, k, l, m) : ");
                char r;
                r = char.Parse(Console.ReadLine());
                switch (r) {
                    case 'a':
                        SumTwoUnsignedIntegers();
                        break;
                    case 'b':
                        RectangleAreaAndPerimeter();
                        break;
                    case 'c':
                        CheckEvenOdd();
                        break;
                    case 'd':
                        SumTwoSignedIntegers();
                        break;
                    case 'e':
                        SumFromOneToN();
                        break;
                    case 'g':
                        RectangleAreaAndPerimeterDouble();
                        break;
                    case 'h':
                        FindLargestNumber();
                        break;
                    case 'k':
                        CalculateFactorial();
                        break;
                    case 'l':
                        CheckPrimeNumber();
                        break;
                    case 'm':
                        CheckPerfectNumber();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
                Console.WriteLine("Ban muon tiep tuc chay chuong trinh khong (y/n)?");
                string s = Console.ReadLine();
                if (s == "n")
                    n = false;
                    
            }
            catch (System.Exception)
            {
                Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
                throw;
            }
        }
    }

    public static void SumTwoUnsignedIntegers() {
        Console.WriteLine("Bai7: a) Tong 2 so nguyen khong dau ");
        Console.Write("Nhap so nguyen dau tien: ");
        uint a = uint.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen thu hai: ");
        uint b = uint.Parse(Console.ReadLine());
        Console.WriteLine("Tong hai so la: {0}", a + b);
    }

    public static void RectangleAreaAndPerimeter() {
        Console.WriteLine("Bai7: b) Dien tich va chu vi hinh chu nhat 2 bytes");
        Console.Write("Nhap chieu dai hinh chu nhat < 65535: ");
        ushort a = ushort.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong hinh chu nhat < 65535: ");
        ushort b = ushort.Parse(Console.ReadLine());
        Console.WriteLine("Dien tich hinh chu nhat la: {0}", a * b);
        Console.WriteLine("Chu vi hinh chu nhat la: {0}", (a + b) * 2);
    }

    public static void CheckEvenOdd() {
        Console.WriteLine("Bai 7: c) Kiem tra chan le so nguyen khong dau 4 bytes ");
        Console.Write("Nhap so nguyen > 0: ");
        uint a = uint.Parse(Console.ReadLine());
        if (a % 2 == 0)
            Console.WriteLine("So {0} la so chan", a);
        else
            Console.WriteLine("So {0} la so le", a);
    }

    public static void SumTwoSignedIntegers() {
        Console.WriteLine("Bai 7: d) Tong 2 so nguyen co dau 1 byte");
        Console.Write("Nhap so nguyen dau tien (-128 -> 127): ");
        sbyte a = sbyte.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen thu hai (-128 -> 127): ");
        sbyte b = sbyte.Parse(Console.ReadLine());
        Console.WriteLine("Tong hai so la: {0}", a + b);
    }

    public static void SumFromOneToN() {
        Console.WriteLine("Bai7: e) tong cac so tu 1 den n (n>0) ");
        Console.Write("Nhap so nguyen: ");
        uint a = uint.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= a; i++) {
            sum += i;
        }
        Console.WriteLine("Tong tu 1 den {0} la: {1}", a, sum);
    }

    public static void RectangleAreaAndPerimeterDouble() {
        Console.WriteLine("Bai 7: g) Dien tich va chu vi hinh chu nhat 8 bytes");
        Console.Write("Nhap chieu dai hinh chu nhat: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong hinh chu nhat: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Dien tich hinh chu nhat la: {0}", a * b);
        Console.WriteLine("Chu vi hinh chu nhat la: {0}", (a + b) * 2);
    }

    public static void FindLargestNumber() {
        Console.WriteLine("Bai 7: h) Tim so lon nhat trong 3 so nguyen");
        Console.Write("Nhap so nguyen thu nhat: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen thu hai: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen thu ba: ");
        int c = int.Parse(Console.ReadLine());
        if (a > b && a > c)
            Console.WriteLine("So {0} la so lon nhat", a);
        else if (b > a && b > c)
            Console.WriteLine("So {0} la so lon nhat", b);
        else
            Console.WriteLine("So {0} la so lon nhat", c);
    }

    public static void CalculateFactorial() {
        Console.WriteLine("Bai 7: k) Giai thua cua 1 so nguyen khong dau");
        Console.Write("nhap so nguyen khong dau: ");
        uint n = uint.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= n; i++) {
            factorial *= i;
        }
        Console.WriteLine("Giai thua cua {0} la: {1}", n, factorial);
    }

    public static void CheckPrimeNumber() {
        Console.WriteLine("Bai 7: l) Kiem tra so nguyen khong dau la so nguyen to");
        Console.Write("Nhap so nguyen khong dau: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0) Console.WriteLine("n phai la so duong");
        if (n == 0 || n == 1) {
            Console.WriteLine("{0} khong phai la so nguyen to", n);
        } else {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) Console.WriteLine("{0} la so nguyen to", n);
            else Console.WriteLine("{0} khong phai la so nguyen to", n);
        }
    }

    public static void CheckPerfectNumber() {
        Console.WriteLine("Bai 7: m) Kiem tra so nguyen la so hoan hao");
        Console.Write("Nhap so nguyen khong dau: ");
        int n = int.Parse(Console.ReadLine());
        if (n == 0 || n == 1) {
            Console.WriteLine("{0} khong phai la so hoan hao", n);
        } else {
            int sum = 0;
            for (int i = 1; i < n; i++) {
                if (n % i == 0) {
                    sum += i;
                }
            }
            if (sum == n) Console.WriteLine("{0} la so hoan hao", n);
            else Console.WriteLine("{0} khong phai la so hoan hao", n);
        }
    }
}