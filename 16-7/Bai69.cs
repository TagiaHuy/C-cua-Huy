// Bài tập 69. File text UTF8, UTF16...
// Bài tập về thao tác với File text, file text UTF-8, file text UTF-16 và file nhị phân
// a. Sử dụng lớp File của C# viết các hàm tìm số dòng, tính số kí tự 1 kí tự cho trước, tính số từ được phân tách bởi dấu cách của file Program.cs.
// b. Viết hàm đọc file UTF-8 là "vd1_read.txt" và ghi sang 1 file UTF-8 là "vd1_ghi.txt" sử dụng lớp tĩnh FILE của C#.
// c. Viết hàm đọc file UTF-16 là "vd1_read.txt" và ghi sang 1 file UTF-16 là "vd1_ghi.txt" sử dụng lớp tĩnh FILE của C#.
// d. Viết hàm C# sử dụng kiểu FILE, ghi 1 mảng 2 chiều các số thực 8 byte lên 1 file nhị phân a2d.dat. Đọc lại file nhị phân vào 1 mảng 2 chiều số thực 8 byte khác để kiểm tra.

using System.Text;

public class Bai69
{
    // a. Sử dụng lớp File của C# viết các hàm tìm số dòng, tính số kí tự 1 kí tự cho trước, tính số từ được phân tách bởi dấu cách của file Program.cs.
    public static void CountLinesAndWords(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        int lineCount = lines.Length;
        int wordCount = 0;

        foreach (string line in lines)
        {
            string[] words = line.Split(' ');
            wordCount += words.Length;
        }

        Console.WriteLine($"Số dòng: {lineCount}");
        Console.WriteLine($"Số kí tự 1 kí tự cho trước: {lineCount}");
        Console.WriteLine($"Số từ được phân tách bởi dấu cách: {wordCount}");
    }

    // b. Viết hàm đọc file UTF-8 là "vd1_read.txt" và ghi sang 1 file UTF-8 là "vd1_ghi.txt" sử dụng lớp tĩnh FILE của C#.
    public static void ReadAndWriteUTF8File(string inputFilePath, string outputFilePath)
    {
        using (StreamReader reader = new StreamReader(inputFilePath, Encoding.UTF8))
        {
            string content = reader.ReadToEnd();
            using (StreamWriter writer = new StreamWriter(outputFilePath, false, Encoding.UTF8))
            {
                writer.Write(content);
            }
        }
    }

    // c. Viết hàm đọc file UTF-16 là "vd1_read.txt" và ghi sang 1 file UTF-16 là "vd1_ghi.txt" sử dụng lớp tĩnh FILE của C#.
    public static void ReadAndWriteUTF16File(string inputFilePath, string outputFilePath)
    {
        using (StreamReader reader = new StreamReader(File.Open(inputFilePath, FileMode.Open), Encoding.Unicode))
        {
            string content = reader.ReadToEnd();
            using (StreamWriter writer = new StreamWriter(File.Open(outputFilePath, FileMode.Create), Encoding.Unicode))
            {
                writer.Write(content);
            }
        }
    }

    // d. Viết hàm C# sử dụng kiểu FILE, ghi 1 mảng 2 chiều các số thực 8 byte lên 1 file nhị phân a2d.dat. Đọc lại file nhị phân vào 1 mảng 2 chiều số thực 8 byte khác để kiểm tra.
    public static void WriteAndReadBinaryFile(double[,] data, string filePath)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            foreach (double value in data)
            {
                writer.Write(value);
            }
        }

        double[,] readData = new double[data.GetLength(0), data.GetLength(1)];
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    readData[i, j] = reader.ReadDouble();
                }
            }
        }

        // Compare the original and read data
        bool isEqual = true;
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                if (data[i, j] != readData[i, j])
                {
                    isEqual = false;
                    break;
                }
            }
        }

        Console.WriteLine($"Is data equal? {isEqual}");
    }



    public static void Main(string[] args)
    {
        // Test function to count lines and words
        string filePath = "Test.txt";
        CountLinesAndWords(filePath);

        // Test function to read and write UTF-8 file
        string inputFilePath = "UTF8.txt";
        string outputFilePath = "UTF8out.txt";
        ReadAndWriteUTF8File(inputFilePath, outputFilePath);

        // Test function to read and write UTF-16 file
        string inputFilePathUTF16 = "UTF16.txt";
        string outputFilePathUTF16 = "UTF16out.txt";
        ReadAndWriteUTF16File(inputFilePathUTF16, outputFilePathUTF16);

        // Test function to write and read binary file
        double[,] data = new double[3, 3]
        {
            { 1.1, 2.2, 3.3 },
            { 4.4, 5.5, 6.6 },
            { 7.7, 8.8, 9.9 }
        };
        string binaryFilePath = "binary.dat";
        WriteAndReadBinaryFile(data, binaryFilePath);
    }
}