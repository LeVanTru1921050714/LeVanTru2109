using LeVanTru2109.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeVanTru2109.Controllers
{
    public class HomeController : Controller
    {
        Giaiphuongtrinh gpt = new Giaiphuongtrinh();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]


   
        public IActionResult Index(string heSoA, string heSoB)
        {
            string message = "";
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string thongBao = gpt.GiaiPhuongTrinhBacNhat(a, b);
            // Gui thong bao ve view
            ViewBag.ketqua =thongBao;
            return View();
        }
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
        // Nhan duoc du lieu tu view gui len
        
      
    }
