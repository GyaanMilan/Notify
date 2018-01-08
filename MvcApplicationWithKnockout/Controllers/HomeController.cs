using MvcApplicationWithKnockout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationWithKnockout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetBasicInfo(Student student) {
            List<Student> students = new List<Student>();
            students = GetDetails();
            if (student!=null)
            {
                students.Add(student);
            }
            
            return Json(students, JsonRequestBehavior.AllowGet);
        
        }
        public ActionResult Save(Student student)
        {



            return RedirectToAction("GetBasicInfo", "Home", student);
        }
        public List<Student> GetDetails()
        {
            List<Student> lststudent = new List<Student>();
            lststudent.Add(new Student()
            {
                Name = "Evanth",
                Age = 23,
                Email = "h.evanthjain@gmail.com",
                Address = "Trichy"
            });
            lststudent.Add(new Student()
            {
                Name = "Kishor",
                Age = 23,
                Email = "kishorkumar1492@gmail.com",
                Address = "Trichy"
            });
            lststudent.Add(new Student()
            {
                Name = "Arun",
                Age = 23,
                Email = "arunkumar1492@gmail.com",
                Address = "karur"
            });
            return lststudent;
        }
       
    }
}
