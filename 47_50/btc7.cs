// Bài tập chương 7: Sử dụng từ điển
// Tạo một chương trình đơn giản trong C# sử dụng Từ điển từ không gian tên System.Collections.Generic để lưu trữ và truy xuất dữ liệu.
// Yêu cầu:
// - Trong hàm Main, tạo một Từ điển <TKey, TValue>.
// - Thêm một số giá trị cặp khóa cho Từ điển. Các khóa phải là duy nhất và có thể thuộc bất kỳ loại nào. Các giá trị cũng có thể thuộc bất kỳ loại nào.
// - Sử dụng phương pháp ContainsKey để kiểm tra xem một khóa có tồn tại trong Từ điển hay không.
// - Sử dụng phương thức TryGetValue để truy xuất giá trị được liên kết với một khóa nhất định một cách an toàn.
// - Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng.
// - Đầu ra của chương trình: Từ điển lưu trữ và truy xuất chính xác giá trị cặp khóa và các phương thức ContainsKey và TryGetValue xác định chính xác xem khóa có tồn tại trong Từ điển hay không và truy xuất giá trị liên quan của nó.

using System;
using System.Collections.Generic;

class Program
{

    // static void Main(string[] args)
    // {
    //     // Tạo một Từ điển <TKey, TValue>
    //     Dictionary<string, int> dictionary = new Dictionary<string, int>();

    //     // Thêm giá trị vào Từ điển
    //     dictionary.Add("one", 1);
    //     dictionary.Add("two", 2);
    //     dictionary.Add("three", 3);

    //     // Kiểm tra xem một khóa có tồn tại trong Từ điển hay không
    //     Console.WriteLine($"ContainsKey('one'): {dictionary.ContainsKey("one")}"); // True
    //     Console.WriteLine($"ContainsKey('four'): {dictionary.ContainsKey("four")}"); // False

    //     // Truy xuất giá trị của một khóa
    //     if (dictionary.TryGetValue("two", out int value)) {
    //         Console.WriteLine($"Value of key 'two': {value}"); // 2
    //     }

    //     // Lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng
    //     foreach (KeyValuePair<string, int> item in dictionary) {
    //         Console.WriteLine($"{item.Key} - {item.Value}");
    //     }
    // }


}