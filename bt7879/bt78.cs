// // Bài tập 78.
// // a. Viết chương trình C# console chạy 1 thread có mã lệnh như sau:
// // var thread = new Thread(() =>
// // {
// //     Console.WriteLine("Thread bắt đầu.");
// //     Thread.Sleep(1000);
// //     Console.WriteLine("Thread kết thúc.");
// // });
// // thread.Start();
// // thread.Join(); // Đợi thread hoàn thành

// // b. Viết chương trình C# tạo hàm static gọi trong chế độ không đồng bộ với mã lệnh sau:
// // public async Task async1()
// // {
// //     Console.WriteLine("Async bắt đầu.");
// //     await Task.Delay(1000);
// //     Console.WriteLine("Async kết thúc.");
// // }
// // c. So sánh hàm thread và hàm gọi trong chế độ không đồng bộ async/await trong C#.

// public class bt78
// {
//     public static async Task async1()
//     {
//         Console.WriteLine("Async bat dau ");
//         await Task.Delay(1000);
//         Console.WriteLine("Async ket thuc.");
//     }
//     public static void Main()
//     {
//         var thread = new Thread(() =>
//         {
//             Console.WriteLine("Thread bắt đầu.");
//             Thread.Sleep(1000);
//             Console.WriteLine("Thread kết thúc.");
//         });
//         thread.Start();
//         thread.Join(); // Đ��i thread hoàn thành

//         var asyncTask = async1();
        
        
//     }
// }