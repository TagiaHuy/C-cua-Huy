// using System;
// using System.Collections;

// public class Baitap1 {
//     public static void Main(string[] args)
//     {
//         char r;
//         Console.Write("ban muon chay bai 1 phan nao (a, b, c) : ");
//         r = char.Parse(Console.ReadLine());
//         switch (r)
//         {
//             case 'a':
//                 IntegerOperations();
//                 break;
//             case 'b':
//                 SumArray();
//                 break;
//             case 'c':
//                 ReverseUnsignedInteger();
//                 break;
//             default:
//                 Console.WriteLine("Lua chon khong hop le!");
//                 break;
//         }
//     }
//     public static void IntegerOperations() {
//         int a = 0, b = 0;

//         do
//         {
//             try
//             {
//                 Console.Write("Nhap so nguyen a (4 bytes): ");
//                 a = int.Parse(Console.ReadLine());
//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
//                 continue;
//             }
//         } while (a < Int32.MinValue || a > Int32.MaxValue);

        
//         do
//         {
//             try
//             {
//                 Console.Write("Nhap so nguyen b (4 bytes): ");
//                 b = int.Parse(Console.ReadLine());
//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
//                 continue;
//             }
//         } while (b < Int32.MinValue || b > Int32.MaxValue);
        
//         Console.WriteLine("Tong: {0}", a + b);
//         Console.WriteLine("Hieu: {0}", a - b);
//         Console.WriteLine("Tich: {0}", a * b);
//         Console.WriteLine("Thuong: {0}", a / b);
//     }

//     public static void SumArray() {
//         int[] arr = new int[4];
//         int sum = 0;

//         for (int i = 0; i < arr.Length; i++)
//         {
//             do
//             {
//                 try
//                 {
//                     Console.WriteLine("Nhap phan tu thu {0}", i + 1);
//                     arr[i] = int.Parse(Console.ReadLine());
//                 }
//                 catch (FormatException)
//                 {
//                     Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
//                     continue;
//                 }   
//             } while (arr[i] < Int32.MinValue || arr[i] > Int32.MaxValue);
//             sum += arr[i];
//         }
//         Console.WriteLine("Tong cac phan tu trong mang: {0}", sum);
//     }

//     public static void ReverseUnsignedInteger() {
//         uint a = 0;

//         do
//         {
//             try
//             {
//                 Console.Write("Nhap so nguyen a (4 bytes): ");
//                 a = uint.Parse(Console.ReadLine());
//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("Sai dinh dang so nguyen! Vui long nhap lai.");
//                 continue;
//             }
//         } while (a < 0 || a > Int32.MaxValue);

//         uint reverse = 0;
//         uint temp = a;

//         while (temp > 0)
//         {
//             reverse = reverse * 10 + temp % 10;
//             temp /= 10;
//         }

//         Console.WriteLine("So nguyen a dao nguoc: {0}", reverse);
//     }
// }