// // Bài tập 62. Đọc file trên vào 1 biến kiểu Dictionary
// // Viết 1 hàm C# static đọc vào 1 json file biết tên file và trả về 1 Dictionary. Viết bằng 2 cách.using System;
// using System.Collections.Generic;
// using Newtonsoft.Json;

// public static class JsonFileReader
// {

//     public static Dictionary<string, object> ReadJsonFile(string fileName)
//     {
//         string json = System.IO.File.ReadAllText(fileName);
//         return JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
//     }

//     public static Dictionary<string, object> ReadJsonFileWithStreamReader(string fileName)
//     {
//         System.IO.StreamReader file = new System.IO.StreamReader(fileName);
//         string json = file.ReadToEnd();
//         file.Close();
//         return JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
//     }

//     public static void Main(string[] args) {
//         Dictionary<string, object> dict = ReadJsonFileWithStreamReader("test.json");
//         Console.WriteLine(JsonConvert.SerializeObject(dict, Formatting.Indented));

//         Dictionary<string, object> dict2 = ReadJsonFile("test.json");
//         Console.WriteLine(JsonConvert.SerializeObject(dict2, Formatting.Indented));
//     }
// }