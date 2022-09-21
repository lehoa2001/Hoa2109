using Microsoft.AspNetCore.Mvc;
using Hoa2109.Models.Process;
namespace Hoa2109.Controllers
{
    public class DemoController : Controller
    {
        //khai báo class theo hướng đối tượng
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        //tạo các action thực thi nhiệm vụ
        public IActionResult Index()
        {
            return View();
        }

    
         //action để nhận dữ liệu từ view giử lên
        [HttpPost]
        public IActionResult Index(string heSoA, string heSoB)
        {
            //ép kiểu dữ liệu của tham số
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string mess = gpt.GiaiPhuongTrinhBacNhat(a,b);
            
            ViewBag.abc = "Kết quả: " + mess;
            return View();
        }
    }
}