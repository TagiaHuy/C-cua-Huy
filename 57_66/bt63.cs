// // Bài tập 63. Viết 1 hàm C# static ghi 1 Dictionary ra file json biết tên file.Hàm trả lại giá trị kiểu gì? Viết bằng 2 cách.Gọi hàm trong Main() để kiểm tra.
// using Newtonsoft.Json;

// public static class JsonFileWriter
// {
//     public static void WriteJsonFile(string fileName, Dictionary<string, object> dictionary)
//     {
//         string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
//         File.WriteAllText(fileName, json);
//     }

//     public static void WriteJsonFileWithStreamWriter(string fileName, Dictionary<string, object> dictionary)
//     {
//         string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
//         using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
//         {
//             file.Write(json);
//         }
//     }

//     public static void Main(string[] args) {
//         Dictionary<string, object> dictionary = new Dictionary<string, object>
//         {
//             {"key1", "value1"},
//             {"key2", "value2"},
//             {"key3", "value3"}
//         };
//         string fileName = "dictionary.json";
//         WriteJsonFile(fileName, dictionary);
//         WriteJsonFileWithStreamWriter(fileName, dictionary);
//         Console.WriteLine($"Json file {fileName} has been created.");
//     }
// }