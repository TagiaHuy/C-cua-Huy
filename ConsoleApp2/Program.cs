// + file Program.cs chứa Main()
// Trong Main() khai báo 1 obs kiểu Person, cấp phát obs là một Student với tên là Nguyễn Văn Nam và khoa "ICT"
// + Kiểm tra obs là Student hay không?
// + Nếu đúng gọi phương thức kpi()
using System;

public class Program {
    public static void Main() {
        Person obs = new Student{Name = "Nguyen Van Nam", Major = "ICT"};
        
        if ( obs is Student student) {
            student.Kpi();
        }
    }
}