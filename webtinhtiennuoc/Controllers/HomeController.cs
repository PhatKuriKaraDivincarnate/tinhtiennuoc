using Microsoft.AspNetCore.Mvc;
using webtinhtiennuoc.Models;
using lib_tinhtiennuoc;

namespace webtinhtiennuoc.Controllers
{
    public class HomeController : Controller
    {
        // Action hiển thị form nhập liệu
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Action xử lý logic tính tiền nước khi người dùng nhấn nút "Tính tiền"
        [HttpPost]
        public IActionResult Calculate(double soM3)
        {
            // Kiểm tra số m3 nước nhập vào phải lớn hơn hoặc bằng 0
            if (soM3 < 0)
            {
                ViewBag.Error = "Số m3 nước không được nhỏ hơn 0. Vui lòng nhập lại!";
                return View("Index");
            }

            // Sử dụng thư viện tính tiền nước
            Class1 tinhTien = new Class1();

            // Tính tiền nước
            double tongTien = tinhTien.TinhTien(soM3);

            // Trả kết quả về view
            ViewBag.SoM3 = soM3;
            return View("Index", tongTien);
        }
    }
}
