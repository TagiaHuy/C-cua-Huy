// c.Tạo lớp Student kế thừa Person, cài đặt kpi() của interface Kpi là điểm gpa của sinh viên, lập trình kiểm tra mã sinh viên id phải có độ rộng 8 kí tự và đều là kí tự số, có thêm thuộc tính department, kiểu string, phạm vi public hỗ trợ get, set, department phải thuộc ["ICT","ECO"]. Nếu không phép gán department sẽ báo lỗi.

public class Student : Person, Kpi
{
    float gpa;
    public float kpi()
    {
        return gpa;
    }
    public string Department { get; set; }
    public Student(string name, string id, float gpa, string department) : base(name, id)
    {
        if (department!= "ICT" && department!= "ECO")
        {
            throw new ArgumentException("Department must be either ICT or ECO.");
        }
        this.gpa = gpa;
        this.Department = department;
        if (id.Length!= 8 ||!id.All(char.IsDigit))
        {
            throw new ArgumentException("ID must be 8 digits.");
        }
        Console.WriteLine($"Student created: {Name}, ID: {Id}, Department: {Department}");
    }

    public override string ToString()
    {
        return $"Student: {Name}, ID: {Id}, GPA: {kpi()}, Department: {Department}";
    }
}