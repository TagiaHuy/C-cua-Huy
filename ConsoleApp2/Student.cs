// + file Student.cs : chứa lớp Student kế thừa từ lớp Person và bổ sung thêm thuộc tính Major kiểu string, phạm vi là public,hỗ trợ get, set và cài đặt interface KPI.
// + file Program.cs chứa Main()
// Trong Main() khai báo 1 obs kiểu Person, cấp phát obs là một Student với tên là Nguyễn Văn Nam và khoa "ICT"
public class Student : Person, IKPI {


    public string Major { get; set; }

    public void Kpi()
    {
        Console.WriteLine($"{Name} Da dat KPI {Major}");
    }
}
