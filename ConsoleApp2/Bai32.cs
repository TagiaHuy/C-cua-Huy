// Bài tập 32. Tạo chương trình C# có các file:
// + file Person.cs: chứa lớp Person trừu tượng có thuộc tính
// Name là string, phạm vi là public, hỗ trợ get, set.
// + fiile Interface.cs: chứa 1 interface KPI có 1 phương thức kpi() 
// + file Student.cs : chứa lớp Student kế thừa từ lớp Person và bổ sung thêm thuộc tính Major kiểu string, phạm vi là public,hỗ trợ get, set và cài đặt interface KPI.
// + file Program.cs chứa Main()
// Trong Main() khai báo 1 obs kiểu Person, cấp phát obs là một Student với tên là Nguyễn Văn Nam và khoa "ICT"
// + Kiểm tra obs là Student hay không?
// + Nếu đúng gọi phương thức kpi()
// + Nếu Name và Major không hỗ trợ get, set thì điều gì xảy ra?

using System;

// Khai báo l��p Person
