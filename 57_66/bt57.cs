// using System;
// using Newtonsoft.Json;
// // Bài tập 57.  
// // Viết 1 hàm C# core có đối là biến double r, hàm trả lại 1 json string với 3 trường {"dien_tich" ,"chu_vi" , "duong_kinh"}. 
// // Trong hàm main() nhập vào bán kính r, nhập sai thì nhập lại. 
// // Gọi hàm để hiển thị kết quả đầu ra
// class Program
// {
//     static void Main(string[] args)
//     {
//         double r = 0;
//         bool isValidInput = false;

//         while (!isValidInput)
//         {
//             Console.Write("Enter the radius (r): ");
//             if (double.TryParse(Console.ReadLine(), out r) && r >= 0)
//             {
//                 isValidInput = true;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter a valid number.");
//             }
//         }

//         var result = GetCircleInfo(r);
//         Console.WriteLine(result);
//     }

//     static string GetCircleInfo(double radius)
//     {
//         double area = Math.PI * Math.Pow(radius, 2);
//         double circumference = 2 * Math.PI * radius;
//         double diameter = 2 * radius;

//         var circleInfo = new
//         {
//             dien_tich = area,
//             chu_vi = circumference,
//             duong_kinh = diameter
//         };

//         return JsonConvert.SerializeObject(circleInfo);
//     }
// }