using System;
using System.Text;

namespace BangMaASCII
{
    class Bai9
    {
        //a
        static void Main1()
        {
            Console.Write("Nhập vào một chuỗi kí tự: ");
            string inputString = Console.ReadLine();

            // Đảo ngược chuỗi
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            Console.WriteLine($"Chuỗi đảo ngược: {reversedString}");
        }
        //b
        static void Main2()
        {
            Console.Write("Nhập vào một chuỗi kí tự: ");
            string inputString = Console.ReadLine();

            // Tách chuỗi thành các từ
            string[] words = inputString.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Đếm số lượng từ
            int wordCount = words.Length;

            Console.WriteLine($"Số lượng từ trong chuỗi: {wordCount}");
        }

        public static void Main(string[] args) {
        bool n = true;

        while (n)
        {
            try
            {
                Console.Write("ban muon chay bai 8 phan nao (a, b, c, d) : ");
                char r;
                r = char.Parse(Console.ReadLine());
                switch (r) {
                    case 'a':
                        Main1();
                        break;
                    case 'b':
                        Main2();
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
            }
        }
    
        }
    
    }   
}
