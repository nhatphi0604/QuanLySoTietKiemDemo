using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySoTietKiem.Controllers
{
    public class NhanVienDichVuController : Controller
    {
        // GET: NhanVienDichVu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangNhapNVDV()
        {
            return View();
        }
        public ActionResult DangNhapThanhCongNVDV()
        {
            return View();
        }
    }
}