// Bài tập 48.
// Nhập vào 1 danh sách các đối tượng Student gồm 2 trường ID kiểu string và GPA (điểm trung bình). Nếu nhập điểm trung bình sai thì bỏ qua, nếu nhập trường ID là "#" thì dừng việc nhập. 
// Tạo 1 biến dict1 kiểu Diction gồm khóa là ID và trường giá trị là điểm trung bình. Xác định điểm trung bình của sinh viên có ID là "123456".

using System;
using System.Collections.Generic;
class bt48
{
    // public static void Main(string[] args) {
    //     string ID;
    //     float GPA = 0;
    //     Dictionary<string, float> dict1 = new Dictionary<string, float>();
    //     Console.WriteLine("Nhap so luong sinh vien");
    //     int n = Convert.ToInt32(Console.ReadLine());
    //     for (int i = 0; i < n; i++) {
    //         Console.WriteLine("Nhap ma sinh vien");
    //         ID = Console.ReadLine();
    //         if (ID == "#") break;
    //         Console.WriteLine("Nhap diem trung binh sinh vien");
    //         while (!float.TryParse(Console.ReadLine(), out GPA) || GPA < 0 || GPA > 10) {
    //             Console.WriteLine("Nhap sai, nhap lai diem trung binh (0-10)");
    //         }
    //         dict1.Add(ID, GPA);
    //     }

    //     Console.WriteLine("Diem trung binh cua sinh vien co ID la 123456 la: " + dict1["123456"]);
    // }

}