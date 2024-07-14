// Bài tập 66.Viết 1 hàm C# static đọc 1 file csv các số thực ,file csv có thể có header hoặc không có header biết tên file vào 1 mảng 2 chiều...Hàm trả lại mảng...
public static class CsvFileReader
{
    public static double[,] ReadCsvFile(string fileName)
    {
        List<double[,]> matrices = new List<double[,]>();
        string[] lines = File.ReadAllLines(fileName);

        if (lines.Length == 0)
        {
            return new double[0, 0];
        }

        bool hasHeader = lines[0].Contains(",");
        int rowCount = lines.Length - (hasHeader ? 1 : 0);
        int columnCount = lines[0].Split(',').Length;

        double[,] matrix = new double[rowCount, columnCount];

        for (int i = 0; i < rowCount; i++)
        {
            string[] values = lines[i + (hasHeader ? 0 : 1)].Split(',');
            for (int j = 0; j < columnCount; j++)
            {
                matrix[i, j] = double.Parse(values[j]);
            }
        }

        matrices.Add(matrix);
        return matrix;
    }

    public static void Main()
    {
        double[,] matrix = ReadCsvFile("test.csv");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}