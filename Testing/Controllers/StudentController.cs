using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Servicios;
using Capa_Entidades;

namespace Testing.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ShowStudents()
        {
            return View(new StudentServices().GetStudents());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            var servicios = new StudentServices();
            servicios.AddNewStudent(student);

            return RedirectToAction("ShowStudents");
        }
    }
}