// Bài tập 80.
// a. Viết 1 hàm static ff của C# console project thực hiện:
// 1 vòng lặp vô hạn trong thân vòng lặp:
// có 1 lệnh tạo 1 số nguyên ngẫu nhiên n, nếu n chia hết cho 2025 thì dừng lại, trái lại hiển thị n, delay 100ms.
// b. Đặt ff để thực thi trong 1 luồng, khi kết thúc luồng thì hiển thị "Đã thực hiện xong".


// class Program
// {
//     static void Main(string[] args)
//     {
//         Thread t = new Thread(FF);
//         t.Start();
//     }

//     static void FF()
//     {
//         Random random = new Random();

//         while (true)
//         {
//             int n = random.Next(1, 10000);

//             if (n % 2025 == 0)
//                 break;

//             Console.WriteLine(n);
//             Thread.Sleep(100);
//         }
//         Console.WriteLine("Đã thực hiện xong");
//     }
// }