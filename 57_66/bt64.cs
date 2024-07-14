// // Bài tập 64.Viết 1 hàm C# static, ghi 1 mảng 2 chiều các số thực 4 byte ra 1 file csv không có header biết tên file.Gọi hàm trong hàm Main().
// using System;
// using System.Collections.Generic;
// using System.IO;

// public static class CsvFileWriter
// {
//     public static void WriteCsvFile(string fileName, double[,] matrix)
//     {
//         using (StreamWriter file = new StreamWriter(fileName))
//         {
//             for (int i = 0; i < matrix.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrix.GetLength(1); j++)
//                 {
//                     file.Write(matrix[i, j]);
//                     if (j < matrix.GetLength(1) - 1)
//                     {
//                         file.Write(",");
//                     }
//                 }
//                 file.WriteLine();
//             }
//         }
//     }

//     public static void Main()
//     {
//         double[,] matrix = new double[,]
//         {
//             { 1.1, 2.2, 3.3 },
//             { 4.4, 5.5, 6.6 },
//             { 7.7, 8.8, 9.9 }
//         };

//         CsvFileWriter.WriteCsvFile("test.csv", matrix);
//     }
// }