// d. Trong hàm Main() của lớp Program, khai báo obs kiểu Person và gán null.
Person obs;

// e. Cấp phát obs là Student có name là "Nguyễn Tiến Dũng", id là "12345678", department là "ICT". Hiển thị kpi()
obs = new Student("Nguyễn Tiến Dũng", "12345678", 3, "ICT");
// Student obs2 = new Student("Nguyễn Tiến Dũng", "12345678", 3, "IdCT");
// Student obs3 = new Student("Nguyễn Tiến Dũng", "1235678", 3, "ICT");
// h. Khai báo các biến danh sách list1, list2 các đối tượng Person.
// Nhập vào từ bàn phím list1 các sinh viên ngồi bàn 1 lớp 23IT5 ngày 25/06/2024, kết thúc nhập nếu nhập name là #
// Nhập vào từ bàn phím list2 các sinh viên ngồi bàn 2 lớp 23IT6 ngày 25/06/2024, kết thúc nhập nếu nhập name là #
// Hiển thị list1, list2
List<Person> List1, List2;

Console.WriteLine("Nhập các sinh viên ngồi bàn 1 lớp 23IT5 ngày 25/06/2024");

List1 = new List<Person>();

Console.WriteLine("Nhập tên sinh viên (hoặc # để thoát): ");
string Name = Console.ReadLine();

while (Name!= "#")
{
    Console.WriteLine("Nhập gpa sinh viên: ");
    int gpa = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhập id: ");
    string id = Console.ReadLine();
    Console.WriteLine("Nhập phòng: ");
    string department = Console.ReadLine();
    List1.Add(new Student(Name, id, gpa, department));
    Console.WriteLine("Nhập tên sinh viên (hoặc # để thoát): ");
    Name = Console.ReadLine();
}
Console.WriteLine("Nhập các sinh viên ngồi bàn 2 lớp 23IT5 ngày 25/06/2024");

List2 = new List<Person>();

Console.WriteLine("Nhập tên sinh viên (hoặc # để thoát): ");
Name = Console.ReadLine();

while (Name!= "#")
{
    Console.WriteLine("Nhập gpa sinh viên: ");
    int gpa = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhập id: ");
    string id = Console.ReadLine();
    Console.WriteLine("Nhập phòng: ");
    string department = Console.ReadLine();
    List2.Add(new Student(Name, id, gpa, department));
    Console.WriteLine("Nhập tên sinh viên (hoặc # để thoát): ");
    Name = Console.ReadLine();
}


foreach (Student student in List1) {
    Console.WriteLine(student.ToString());
}

foreach (Student student in List2) {
    Console.WriteLine(student.ToString());
}


// k. Khai báo 1 list_list kiểu List của List, và bổ sung list1, list2 vào list_list.
// Hiển thị list_list.
// l. Tạo Diction dic11 cho list1 Student với trường khóa id.
// Tìm trong dict1 bạn có tên là "Nam". Hiển thị các sinh viên tìm được.

List<List<Person>> list_list = new List<List<Person>>();

list_list.Add(List1);

list_list.Add(List2);

foreach (List<Person> list in list_list) {
    foreach (Person student in list) {
        Console.WriteLine(student.ToString());
    }
}

Dictionary<string, Student> dic11 = new Dictionary<string, Student>();
