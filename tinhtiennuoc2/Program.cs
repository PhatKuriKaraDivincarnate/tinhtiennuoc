using lib_tinhtiennuoc;
using System;
using System.Collections.Generic;
using System.Text;

namespace tinhtiennuoc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng TinhTienNuoc từ DLL
            Class1 tinhTien = new Class1();

            // Nhập số m3 nước từ người dùng
            Console.Write("Nhập số m3 nước đã sử dụng: ");
            double soM3 = double.Parse(Console.ReadLine());

            try
            {
                // Gọi phương thức TinhTien từ DLL và hiển thị kết quả
                double tongTien = tinhTien.TinhTien(soM3);
                Console.WriteLine($"Số tiền phải trả là: {tongTien} VND");
            }
            catch (ArgumentException ex)
            {
                // Bắt lỗi nếu số m3 nhỏ hơn 0
                Console.WriteLine(ex.Message);
            }

            // Dừng màn hình để xem kết quả
            Console.ReadKey();
        }
    }
}
