using System;
using System.Text;

namespace BangMaASCII
{
    class Bai8
    {
        //a
        static void ASCII ()
        {
            // Hiển thị tiêu đề
            Console.WriteLine("Bảng mã ASCII");

            // Hiển thị hàng đầu tiên (mã từ 0 đến 31)
            for (int i = 0; i < 32; i++)
            {
                Console.Write("{0,3:d} - {1}", i, (char)i);
            }

            // Hiển thị các hàng còn lại (mã từ 32 đến 127)
            for (int i = 32; i < 128; i++)
            {
                if (i % 16 == 0)
                {
                    Console.WriteLine();
                }

                Console.Write("{0,3:d} - {1}", i, (char)i);
            }
        }

        //b
        static void UTF8 ()
        {
            // Define the encoding for code page 65001
            Encoding encoding = Encoding.GetEncoding(65001);

            // Iterate through all characters in the code page
            for (int i = 0; i < 256; i++)
            {
                // Convert the code point to a byte array
                byte[] bytes = new byte[] { (byte)i };

                // Decode the byte array to a character using the specified encoding
                char character = encoding.GetString(bytes)[0];

                // Display the character and its code point
                Console.WriteLine("{0,3:d} - {1}", i, character);
            }
        }

        //c
        static void Beep()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    Console.Beep();
                } else
                {
                    break;
                }
            }
        }

        //d
        static void Array ()
        {
            Console.Write("Nhap chuoi ky tu: ");
            string inputString = Console.ReadLine();

            // Tạo một mảng để lưu số lần xuất hiện của mỗi ký tự (sử dụng mã ASCII)
            int[] charCount = new int[256];

            // Duyệt qua từng ký tự trong chuỗi
            foreach (char c in inputString)
            {
                // Tăng số lần xuất hiện của ký tự tương ứng
                charCount[(int)c]++;
            }

            // Hiển thị kết quả đếm
            Console.WriteLine("so lan xuat hien cua moi ky tu trong chuoi:");
            for (int i = 0; i < 256; i++)
            {
                if (charCount[i] > 0)
                {
                    Console.WriteLine($"Ky tu {(char)i}: {charCount[i]} lan");
                }
            }
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
                        ASCII();
                        break;
                    case 'b':
                        UTF8();
                        break;
                    case 'c':
                        Beep();
                        break;
                    case 'd':
                        Array();
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
