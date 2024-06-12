using System;
using System.IO;

namespace DocGhiFileVanBan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập tên file: ");
            string fileName = Console.ReadLine();

            // Ghi nội dung vào file
            Console.Write("Nhập nội dung: ");
            string content = Console.ReadLine();
            File.WriteAllText(fileName, content);

            // Đọc nội dung từ file và hiển thị lên màn hình
            string readContent = File.ReadAllText(fileName);
            Console.WriteLine($"Nội dung từ file {fileName}:\n{readContent}");
        }
    }
}
