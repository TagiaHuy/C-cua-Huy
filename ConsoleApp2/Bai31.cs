using System;
using System.Collections.Generic;
using System.IO;

class SinhVien {
    public string MSSV { get; set; }
    public string HoTen { get; set; }
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }
    
    public double DiemTrungBinh {
        get { return (DiemToan + DiemLy + DiemHoa) / 3; }
    }
}

class Program1 {
    public static List<SinhVien> danhSachSinhVien = new List<SinhVien>();
    
    // static void Main(string[] args) {
    //     try {
    //         Console.Write("Nhập số lượng sinh viên: ");
    //         int soSinhVien = Convert.ToInt32(Console.ReadLine());
            
    //         NhapThongTinSinhVien(soSinhVien);
            
    //         double[] diemTrungBinh = TinhDiemTrungBinh(danhSachSinhVien);
            
    //         HienThiThongTinSinhVien(danhSachSinhVien, diemTrungBinh);
            
    //         HienThiSinhVienDauTienCoDiemTrungBinh(danhSachSinhVien, diemTrungBinh);
            
    //         Console.WriteLine($"Sinh viên có điểm trung bình lớn hơn 5.0: {DemSinhVienCoDiemTrungBinhLonHon5(danhSachSinhVien, diemTrungBinh)}");
    //         Console.WriteLine($"Sinh viên có điểm trung bình lớn hơn 9.5: {DemSinhVienCoDiemTrungBinhLonHon9_5(danhSachSinhVien, diemTrungBinh)}");

    //         SapXepTheoDiemTrungBinh(danhSachSinhVien);
            
    //         SapXepTheoHoTen(danhSachSinhVien);

    //         Console.Write("Nhập tên file để ghi thông tin sinh viên: ");
    //         string tenFile = Console.ReadLine();
    //         GhiThongTinSinhVienVaoFile(tenFile, danhSachSinhVien);
            
    //         Console.Write("Nhập tên file để đọc thông tin sinh viên: ");
    //         string tenFileDoc = Console.ReadLine();
    //         List<SinhVien> danhSachSinhVienDoc = DocThongTinSinhVienTuFile(tenFileDoc);
    //         HienThiThongTinSinhVien(danhSachSinhVienDoc, TinhDiemTrungBinh(danhSachSinhVienDoc));
    //         Console.WriteLine();
    //         Console.WriteLine("Sinh viên đã đọc từ file:");

    //         SapXepTheoDiemTrungBinh(danhSachSinhVienDoc);
            
    //         SapXepTheoHoTen(danhSachSinhVienDoc);

    //     } catch (Exception e) {
    //         Console.WriteLine("Loi: " + e.Message);
    //     }
    // }

    static void HienThiThongTinSinhVien(List<SinhVien> danhSachSinhVien, double[] diemTrungBinh) {
        for (int i = 0; i < danhSachSinhVien.Count; i++) {
            Console.WriteLine($"Mã sinh viên: {danhSachSinhVien[i].MSSV}");
            Console.WriteLine($"Họ tên sinh viên: {danhSachSinhVien[i].HoTen}");
            Console.WriteLine($"Điểm trung bình: {diemTrungBinh[i]}");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
    }
    
    static void HienThiSinhVienDauTienCoDiemTrungBinh(List<SinhVien> danhSachSinhVien, double[] diemTrungBinh) {
        int indexSinhVienDauTien = 0;
        
        for (int i = 1; i < danhSachSinhVien.Count; i++) {
            if (diemTrungBinh[i] < diemTrungBinh[indexSinhVienDauTien]) {
                indexSinhVienDauTien = i;
            }
        }
        
        Console.WriteLine($"Sinh viên đầu tiên có điểm trung bình: {danhSachSinhVien[indexSinhVienDauTien].HoTen}");
        Console.WriteLine($"Điểm trung bình: {diemTrungBinh[indexSinhVienDauTien]}");
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        Console.WriteLine();
    }

    static int DemSinhVienCoDiemTrungBinhLonHon5(List<SinhVien> danhSachSinhVien, double[] diemTrungBinh) {
        int soSinhVienCoDiemTrungBinhLonHon5 = 0;
        
        for (int i = 0; i < danhSachSinhVien.Count; i++) {
            if (diemTrungBinh[i] > 5.0) {
                soSinhVienCoDiemTrungBinhLonHon5++;
            }
        }
        
        return soSinhVienCoDiemTrungBinhLonHon5;
    }

    static int DemSinhVienCoDiemTrungBinhLonHon9_5(List<SinhVien> danhSachSinhVien, double[] diemTrungBinh) {
        int soSinhVienCoDiemTrungBinhLonHon9_5 = 0;
        
        for (int i = 0; i < danhSachSinhVien.Count; i++) {
            if (diemTrungBinh[i] > 9.5) {
                soSinhVienCoDiemTrungBinhLonHon9_5++;
            }
        }

        return soSinhVienCoDiemTrungBinhLonHon9_5;
    }

    static void SapXepTheoDiemTrungBinh(List<SinhVien> danhSachSinhVien) {
        danhSachSinhVien.Sort((a, b) => b.DiemTrungBinh.CompareTo(a.DiemTrungBinh));
        
        Console.WriteLine("Danh sách sinh viên theo thứ tự điểm trung bình từ cao đến thấp:");
        foreach (SinhVien sv in danhSachSinhVien) {
            Console.WriteLine($"Mã sinh viên: {sv.MSSV}");
            Console.WriteLine($"Họ tên sinh viên: {sv.HoTen}");
            Console.WriteLine($"Điểm trung bình: {sv.DiemTrungBinh}");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
    }

    static void NhapThongTinSinhVien(int soSinhVien) {
        for (int i = 0; i < soSinhVien; i++) {
            SinhVien sv = new SinhVien();
            
            Console.Write($"Nhập mã sinh viên {i + 1}: ");
            sv.MSSV = Console.ReadLine();
            
            Console.Write($"Nhập họ tên sinh viên {i + 1}: ");
            sv.HoTen = Console.ReadLine();
            
            Console.Write($"Nhập điểm toán sinh viên {i + 1}: ");
            sv.DiemToan = Convert.ToDouble(Console.ReadLine());
            
            Console.Write($"Nhập điểm lý sinh viên {i + 1}: ");
            sv.DiemLy = Convert.ToDouble(Console.ReadLine());
            
            Console.Write($"Nhập điểm hóa sinh viên {i + 1}: ");
            sv.DiemHoa = Convert.ToDouble(Console.ReadLine());
            danhSachSinhVien.Add(sv);
            
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
    }

    static double[] TinhDiemTrungBinh(List<SinhVien> danhSachSinhVien) {
        double[] diemTrungBinh = new double[danhSachSinhVien.Count];
        
        for (int i = 0; i < danhSachSinhVien.Count; i++) {
            diemTrungBinh[i] = danhSachSinhVien[i].DiemTrungBinh;
        }
        
        return diemTrungBinh;
    }
 
    static void SapXepTheoHoTen(List<SinhVien> danhSachSinhVien) {
        danhSachSinhVien.Sort((a, b) => a.HoTen.CompareTo(b.HoTen));
        
        Console.WriteLine("Sinh viên sắp xếp theo họ tên:");
        Console.WriteLine("----------------------------------");
        
        foreach (var sv in danhSachSinhVien) {
            Console.WriteLine($"MSSV: {sv.MSSV}");
            Console.WriteLine($"Họ tên: {sv.HoTen}");
            Console.WriteLine($"Điểm trung bình: {sv.DiemTrungBinh}");
            Console.WriteLine();
        }
    }
    
    static void GhiThongTinSinhVienVaoFile(string tenFile, List<SinhVien> danhSachSinhVien) {
        using (StreamWriter sw = new StreamWriter(tenFile)) {
            foreach (var sv in danhSachSinhVien) {
                sw.WriteLine($"{sv.MSSV},{sv.HoTen},{sv.DiemToan},{sv.DiemLy},{sv.DiemHoa}");
            }
        }
        
        Console.WriteLine($"Thông tin sinh viên đã ghi vào file {tenFile}");
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        Console.WriteLine();
    }
    
    static List<SinhVien> DocThongTinSinhVienTuFile(string tenFile) {
        List<SinhVien> sinhViens = new List<SinhVien>();
        string[] lines = File.ReadAllLines(tenFile);

        foreach (var line in lines) {
            string[] values = line.Split(',');
            SinhVien sv = new SinhVien();
            sv.MSSV = values[0];
            sv.HoTen = values[1];
            sv.DiemToan = Convert.ToDouble(values[2]);
            sv.DiemLy = Convert.ToDouble(values[3]);
            sv.DiemHoa = Convert.ToDouble(values[4]);
            sinhViens.Add(sv);
        }
        
        Console.WriteLine($"Thông tin sinh viên đã đọc từ file {tenFile}");
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        Console.WriteLine();
        
        return sinhViens;
    }

}