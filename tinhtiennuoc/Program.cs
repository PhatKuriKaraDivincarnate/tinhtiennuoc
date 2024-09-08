using System;
using System.Collections.Generic;
using System.Text;
// Họ và tên : Nguyễn CHí Phát
// Bắt đầu làm bài toán : tính tiền nước 

namespace tinhtiennuoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo các mức giá tiền nước theo m3
            const double giaMuc1 = 5000;   // Mức giá cho 10 m3 đầu tiên
            const double giaMuc2 = 7000;   // Mức giá cho 10 m3 tiếp theo (từ 11 đến 20 m3)
            const double giaMuc3 = 10000;  // Mức giá cho m3 tiếp theo (trên 20 m3)

            // Nhập số m3 nước đã sử dụng
            Console.Write("Nhap so m3 nuoc da su dung : ");
            double soM3 = double.Parse(Console.ReadLine());

            // Kiểm tra nếu số khối nước nhỏ hơn 0
            if (soM3 < 0)
            {
                Console.WriteLine("Loi : so m3 nuoc su dung khong the nho hon 0.");
            }
            else
            {
                // Biến lưu trữ tiền phải trả
                double tongTien = 0;

                // Tính tiền dựa trên các mức giá
                if (soM3 <= 10)
                {
                    tongTien = soM3 * giaMuc1;
                }
                else if (soM3 <= 20)
                {
                    tongTien = 10 * giaMuc1 + (soM3 - 10) * giaMuc2;
                }
                else
                {
                    tongTien = 10 * giaMuc1 + 10 * giaMuc2 + (soM3 - 20) * giaMuc3;
                }

                // Hiển thị số tiền phải trả
                Console.WriteLine($"So tien phai tra la : {tongTien} VND");
            }

            // Dừng màn hình để xem kết quả
            Console.ReadKey();
        }
    }
}
