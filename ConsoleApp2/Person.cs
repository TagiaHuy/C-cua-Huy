// Bài tập 32. Tạo chương trình C# có các file:
// + file Person.cs: chứa lớp Person trừu tượng có thuộc tính
// Name là string, phạm vi là public, hỗ trợ get, set.

// + Kiểm tra obs là Student hay không?
// + Nếu đúng gọi phương thức kpi()
// + Nếu Name và Major không hỗ trợ get, set thì điều gì xảy ra?

using System;

// Khai báo l��p Person

public abstract class Person
{
    public string Name { get; set; }
}