using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySoTietKiem.Controllers
{
    public class NhanVienKeToanController : Controller
    {
        // GET: NhanVienkeToan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangNhapNVKT()
        {
            return View();
        }
        public ActionResult DangNhapThanhCongNVKT()
        {
            return View();
        }
        public ActionResult BaoCaoGuiVaRutTienThangNVKT()
        {
            return View();
        }
        public ActionResult TinhTongTienNVKT()
        {
            return View();
        }
        public ActionResult ThayDoiLaiSuatNVKT()
        {
            return View();
        }
        public ActionResult ThayDoiSoTienNVKT()
        {
            return View();
        }
        public ActionResult ThayDoiThoiGianNVKT()
        {
            return View();
        }
    }
}