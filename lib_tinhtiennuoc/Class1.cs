using System;
using System.Collections.Generic;
using System.Text;

namespace lib_tinhtiennuoc
{
    public class Class1
    {
        // Các mức giá
        private const double giaMuc1 = 5000;   // Mức giá cho 10 m3 đầu tiên
        private const double giaMuc2 = 7000;   // Mức giá cho 10 m3 tiếp theo (từ 11 đến 20 m3)
        private const double giaMuc3 = 10000;  // Mức giá cho m3 tiếp theo (trên 20 m3)

        // Phương thức tính tiền nước
        public double TinhTien(double soM3)
        {
            // Kiểm tra nếu số khối nước nhỏ hơn 0
            if (soM3 < 0)
            {
                throw new ArgumentException("Số m3 nước không thể nhỏ hơn 0.");
            }

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

            return tongTien;
        }
    }
}
