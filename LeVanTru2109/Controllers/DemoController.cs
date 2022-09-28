using Microsoft.AspNetCore.Mvc;
using LeVanTru2109.Models;

namespace LeVanTru2109.Controllers
{
    public class DemoController : Controller
    {
        Giaiphuongtrinh gpt = new Giaiphuongtrinh();
        public IActionResult Index()
        {
            ////Khai bao 1 bien kieu string
            //string soNguyen = "5";
            //// Khai bao 1 so kieu int
            //int so;
            //// so = soNguyen; => Can chuyen doi
            //so = int.Parse(soNguyen);
            // Vi du 2
            // Khai bao bien
            // Kieu Du_lieu ten_Bien = Gia_Tri;
            //int heSoA = 5;
            //int heSoB;
            //double x;
            //string str = "Xin chao";
            //// if else; swith case; do while; while
            //for(int i = 0; i < heSoA; i++)
            //{

            //}

            return View();
        }
        // Nhan duoc du lieu tu view gui len
        [HttpPost]
        public IActionResult Index(string heSoA, string heSoB)
        {
            string message = "";
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string thongBao = gpt.GiaiPhuongTrinhBacNhat(a,b);
            // Gui thong bao ve view
            ViewBag.ketqua = message;
            return View();
        }
        // phương trình bậc 2
        public IActionResult Create(string heSoA, string heSoB, String heSoC)
        {
            double A = Convert.ToDouble(heSoA);
            double B = Convert.ToDouble(heSoB);
            double C = Convert.ToDouble(heSoC);
            string thongBao = gpt.GiaiphuongtrinhBacHai(A, B, C);
            ViewBag.abc = thongBao;
            return View();
        }
    }
}
