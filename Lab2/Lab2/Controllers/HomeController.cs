using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Lesson3()
        {
            List<Models.Lesson3> emp = new List<Lesson3>
            {
                new Lesson3
                {
                    EmployeeId = 1,
                    EmployeeName = "Nhu Sy Hoang Long ",
                    Address = "123 Le Loi, Phuong Ben Nghe, Quan 1, Ho Chi Minh",
                    Phone ="123 098 7654"
                },
                new Lesson3
                {
                    EmployeeId = 4,
                    EmployeeName = "Nguyen Dang Gia Bao ",
                    Address = "56 Nguyen Trai, Phuong 3, Quan 5, Ho Chi Minh",
                    Phone ="123 098 7654"
                },
                new Lesson3
                {
                    EmployeeId = 2,
                    EmployeeName = "Tran Phuong Nam ",
                    Address = "78 Vo Van Tan, Phuong 6, Quan 3, Ho Chi Minh",
                    Phone ="123 098 7654"
                },
                new Lesson3
                {
                    EmployeeId = 3,
                    EmployeeName = "Vu Hoang Nhat Phuong ",
                    Address = "90 Tran Hung Dao, Phuong 1, Quan 5, Ho Chi Minh",
                    Phone ="123 098 7654"
                },

            };
            ViewBag.lesson3 = emp;

            return View();
        }
        public IActionResult Lesson2()
        {
            ViewData["Header"] = "Thông Tin Chi Tiết Sinh Viên";
            var student = new Lesson2()
            {
                ID = 1,
                Name = "Nhu Sy Hoang Long",
                Branch = "FPT Dong Nai",
                Section = "Co So 2",
            };
            ViewData["student"] = student;
            return View();
        }
        public IActionResult London()
        {
            return View();
        }
        public IActionResult Paris()
        {
            return View();
        }
        public IActionResult Tokyo()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
