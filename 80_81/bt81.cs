// Bài tập 81. Phân biệt lệnh Thread.Sleep(100); của gói using System.Threading và lệnh Task.Delay(100); của gói using System.Threading.Tasks
// Thread.Sleep(100)
// Chức năng: Khiến luồng hiện tại (thread) tạm dừng thực thi trong một khoảng thời gian cụ thể (ở đây là 100 mili giây).
// Tác động:
// Khóa luồng: Trong khi luồng đang ngủ, nó không thể thực hiện bất kỳ công việc nào khác.
// Không hiệu quả: Nếu bạn cần thực hiện nhiều tác vụ đồng thời, việc sử dụng Thread.Sleep sẽ làm giảm hiệu suất vì các luồng khác phải chờ luồng này hoàn thành.
// Sử dụng: Thường được sử dụng trong các trường hợp đơn giản, khi bạn chỉ muốn tạm dừng một luồng duy nhất và không cần quản lý nhiều luồng phức tạp.
// Task.Delay(100)
// Chức năng: Tạo một Task (nhiệm vụ) sẽ hoàn thành sau một khoảng thời gian nhất định (100 mili giây).
// Tác động:
// Không khóa luồng: Task.Delay không khóa luồng hiện tại. Bạn có thể tiếp tục thực hiện các công việc khác trong khi chờ Task hoàn thành.
// Hiệu quả: Tận dụng được mô hình lập trình bất đồng bộ, giúp cải thiện hiệu suất ứng dụng.
// Sử dụng:
// Chờ đợi: Sử dụng await Task.Delay(100) để tạm dừng việc thực thi của một phương thức async trong một khoảng thời gian nhất định.
// Tạo các khoảng thời gian: Tạo các khoảng thời gian định kỳ để thực hiện một số tác vụ lặp đi lặp lại.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sử dụng Thread.Sleep
            Console.WriteLine("Bắt đầu Thread.Sleep");
            Thread.Sleep(1000); // Ngủ trong 1 giây
            Console.WriteLine("Kết thúc Thread.Sleep");

            // Sử dụng Task.Delay
            Console.WriteLine("Bắt đầu Task.Delay");
            Task.Delay(1000).Wait(); // Chờ Task hoàn thành
            Console.WriteLine("Kết thúc Task.Delay");
        }
    }
}
