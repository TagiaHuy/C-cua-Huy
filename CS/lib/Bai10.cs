using System;
using System.Text;

namespace BangMaASCII
{
    struct SinhVien
    {
        public string Ten;
        public float Diem;
    }


    class Bai10
    {
        //a
        static void Main1()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            // Khởi tạo mảng SinhVien
            SinhVien[] danhSachSinhVien = new SinhVien[n];

            // Nhập thông tin từng sinh viên
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap thong tin sinh vien {i + 1}:\nTen: ");
                danhSachSinhVien[i].Ten = Console.ReadLine();

                Console.Write("Diem: ");
                danhSachSinhVien[i].Diem = float.Parse(Console.ReadLine());
            }

            // Hiển thị thông tin từng sinh viên
            Console.WriteLine("\nThong tin sinh vien:");
            foreach (var sv in danhSachSinhVien)
            {
                Console.WriteLine($"Ten: {sv.Ten}, Diem: {sv.Diem}");
            }

            // Tính điểm trung bình của cả lớp
            float tongDiem = 0;
            foreach (var sv in danhSachSinhVien)
            {
                tongDiem += sv.Diem;
            }
            float diemTrungBinh = tongDiem / n;

            Console.WriteLine($"\nDiem trung binh: {diemTrungBinh}");
        }
    
        public static void Main(string[] args) {
        bool n = true;

        while (n)
        {
            try
            {
                Console.Write("ban muon chay bai 8 phan nao (a) : ");
                char r;
                r = char.Parse(Console.ReadLine());
                switch (r) {
                    case 'a':
                        Main1();
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
