using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySoTietKiem.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TaoTaiKhoanKH()
        {
            return View();
        }
        public ActionResult DangNhapKH()
        {
            return View();
        }
        public ActionResult DangNhapThanhCongKH()
        {
            return View();
        }
    }
}