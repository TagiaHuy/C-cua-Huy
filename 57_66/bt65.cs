// // Bài tập 65. Viết 1 hàm C# static ghi 1 Dictionary kiểu Value là số thực 8byte ra  1 file csv có header biết tên file.Gọi hàm trong hàm Main().
// public static class CsvFileWriter
// {
//     public static void WriteCsvFileWithHeader(string fileName, Dictionary<string, double> dictionary)
//     {
//         using (StreamWriter file = new StreamWriter(fileName))
//         {
//             file.WriteLine("Key: Value");

//             foreach (var item in dictionary)
//             {
//                 file.Write(item.Key);
//                 file.Write(",");
//                 file.Write(item.Value);
//                 file.WriteLine();
//             }
//         }
//     }

//     public static void Main()
//     {
//         Dictionary<string, double> dictionary = new Dictionary<string, double>
//         {
//             {"key1", 1.1},
//             {"key2", 2.2},
//             {"key3", 3.3}
//         };

//         WriteCsvFileWithHeader("test2.csv", dictionary);
//         Console.WriteLine("CSV file created successfully.");
//     }
// }