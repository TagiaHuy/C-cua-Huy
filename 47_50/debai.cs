// Bài tập chương 7: Sử dụng từ điển
// Tạo một chương trình đơn giản trong C# sử dụng Từ điển từ không gian tên System.Collections.Generic để lưu trữ và truy xuất dữ liệu.
// Yêu cầu:
// - Trong hàm Main, tạo một Từ điển <TKey, TValue>.
// - Thêm một số giá trị cặp khóa cho Từ điển. Các khóa phải là duy nhất và có thể thuộc bất kỳ loại nào. Các giá trị cũng có thể thuộc bất kỳ loại nào.
// - Sử dụng phương pháp ContainsKey để kiểm tra xem một khóa có tồn tại trong Từ điển hay không.
// - Sử dụng phương thức TryGetValue để truy xuất giá trị được liên kết với một khóa nhất định một cách an toàn.
// - Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng.
// - Đầu ra của chương trình: Từ điển lưu trữ và truy xuất chính xác giá trị cặp khóa và các phương thức ContainsKey và TryGetValue xác định chính xác xem khóa có tồn tại trong Từ điển hay không và truy xuất giá trị liên quan của nó.



// Bài tập 48.
// Nhập vào 1 danh sách các đối tượng Student gồm 2 trường ID kiểu string và GPA (điểm trung bình). Nếu nhập điểm trung bình sai thì bỏ qua, nếu nhập trường ID là "#" thì dừng việc nhập. 
// Tạo 1 biến dict1 kiểu Diction gồm khóa là ID và trường giá trị là điểm trung bình. Xác định điểm trung bình của sinh viên có ID là "123456".



// Bài 49. Viết chương trình C#, trong đó viết 1 hàm static Generic 1 biến đa công dụng: 
// - Có thể truyền 1 mảng các số nguyên 4 byte, mảng số nguyên không dấu 4 byte, mảng số thực 4byte hoặc mảng số thực 8 byte để nhận về giá trị bé nhất của mảng. 
// - Hàm duyệt mảng theo từng phần tử để xác định giá trị nhỏ nhất.
// - Trong lớp chứa hàm Main() gọi hàm để thử cho các trường hợp của biến mảng như sau:
// + Khai báo 1 biến kiểu dynamic là min_value
// + Gọi hàm với mảng số nguyên 4 byte và gán giá trị trả về cho min_value rồi sử dụng ToString() để in ra giá trị của min_value
// + Gọi hàm với mảng số nguyên 4 byte không dấu và gán giá trị trả về cho min_value rồi sử dụng ToString() để in ra giá trị của min_value.



// Bài tập 50. Có thể thay  
// min_value = FindMin<int>(intArray); 
// thành 
// min_value = FindMin(intArray); 

// min_value = FindMin<double>(doubleArray);
// thành
// min_value = FindMin(doubleArray);

// ...
// được không?    => Khong vi No se khong the xac dinh duoc kieu du lieu 
// Khai báo biến 
// dynamic min_value;
// có tác dụng thế nào?