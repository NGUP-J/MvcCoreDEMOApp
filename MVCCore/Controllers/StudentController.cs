using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace MVCCore.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return Content("คะแนนสอบวิชาคอมพิวเตอร์");
        }

        public IActionResult Details()
        {
            return Content("รายละเอียดคะแนนสอบ");
        }
        public IActionResult ShowScore(int id)
        {
            return Content($"คะแนนสอบของนักเรียน เลขที่ {id}");
        }
    }
}
