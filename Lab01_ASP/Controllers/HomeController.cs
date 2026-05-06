using Lab01_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab01_ASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var majors = new List<model>
            {
                new model { SubName = "Thiết kế đồ họa", Image = "/img/images/image1.png" },
                new model { SubName = "LẬP TRÌNH DI ĐỘNG", Image = "/img/images/image2.png" },
                new model { SubName = "THIẾT KẾ WEBSITE", Image = "/img/images/image3.png" },
                new model { SubName = "ỨNG DỤNG PHẦN MỀM", Image = "/img/images/image4.png" }
            };
            return View(majors);
        }

        public IActionResult subject()
        {
            var dsNganh = model2.GetMajors();

            return View(dsNganh);
        }

    }
}
