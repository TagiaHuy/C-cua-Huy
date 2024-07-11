// Bài 49. Viết chương trình C#, trong đó viết 1 hàm static Generic 1 biến đa công dụng: 
// - Có thể truyền 1 mảng các số nguyên 4 byte, mảng số nguyên không dấu 4 byte, mảng số thực 4byte hoặc mảng số thực 8 byte để nhận về giá trị bé nhất của mảng. 
// - Hàm duyệt mảng theo từng phần tử để xác định giá trị nhỏ nhất.
// - Trong lớp chứa hàm Main() gọi hàm để thử cho các trường hợp của biến mảng như sau:
// + Khai báo 1 biến kiểu dynamic là min_value
// + Gọi hàm với mảng số nguyên 4 byte và gán giá trị trả về cho min_value rồi sử dụng ToString() để in ra giá trị của min_value
// + Gọi hàm với mảng số nguyên 4 byte không dấu và gán giá trị trả về cho min_value rồi sử dụng ToString() để in ra giá trị của min_value.

class bt49
{
    static void Main()
    {
        dynamic min_value;
        min_value = FindMinimumValue(new int[] { 5, 2, 8, 1, 4 });
        Console.WriteLine("Smallest integer: " + min_value.ToString());
        // int[] intArray = { 5, 2, 8, 1, 4 };
        // ushort[] ushortArray = { 10, 20, 15, 5 };
        // float[] floatArray = { 1.5f, 2.5f, 3.5f, 4.5f };
        // double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };

        // Console.WriteLine("Smallest integer: " + FindMinimumValue(intArray));
        // Console.WriteLine("Smallest unsigned integer: " + FindMinimumValue(ushortArray));
        // Console.WriteLine("Smallest single-precision floating-point number: " + FindMinimumValue(floatArray));
        // Console.WriteLine("Smallest double-precision floating-point number: " + FindMinimumValue(doubleArray));

    }
    public static T FindMinimumValue<T> (T[] array) where T : IComparable<T> {
        T min_value = array[0];
        for (int i = 1; i < array.Length; i++) {
            if (array[i].CompareTo(min_value) < 0) {
                min_value = array[i];
            }
        }
        return min_value;
    } 
}