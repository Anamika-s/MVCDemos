using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                 new Student(){ Id=1, Name="Ajay", Marks=90, BatchCode="B001"},
                 new Student(){ Id=2, Name="Deepak", Marks=89, BatchCode="B002"},
                 new Student(){ Id=3, Name="Ajay", Marks=90, BatchCode="B001"},
                 new Student(){ Id=4, Name="Deepak", Marks=89, BatchCode="B002"},
                 new Student(){ Id=5, Name="Ajay", Marks=90, BatchCode="B001"},
                 new Student(){ Id=6, Name="Deepak", Marks=89, BatchCode="B002"},
                 new Student(){ Id=7, Name="Ajay", Marks=90, BatchCode="B001"},
                 new Student(){ Id=8, Name="Deepak", Marks=89, BatchCode="B002"},
                };
            ViewBag.students = students;
            return View();
              }

        public ActionResult Display()
        {
            Student student = new Student() { Id = 1, Name = "Ajay", Marks = 90, BatchCode = "B001" };
            ViewBag.student = student;
            return View();
        }

        public ActionResult Display1()
        {
            Student student = new Student() { Id = 1, Name = "Ajay", Marks = 90, BatchCode = "B001" };
            return View(student);
        }




        public ActionResult Index1()
        {
            List<Student> students = new List<Student>()
            {
                 new Student(){ Id=1, Name="Ajay", Marks=90, BatchCode="B001"},
                 new Student(){ Id=2, Name="Deepak", Marks=89, BatchCode="B002"},
                 new Student(){ Id=3, Name="Ajay", Marks=90, BatchCode="B001"},
                 new Student(){ Id=4, Name="Deepak", Marks=89, BatchCode="B002"},
                 new Student(){ Id=5, Name="Ajay", Marks=90, BatchCode="B001"},
                 new Student(){ Id=6, Name="Deepak", Marks=89, BatchCode="B002"},
                 new Student(){ Id=7, Name="Ajay", Marks=90, BatchCode="B001"},
                 new Student(){ Id=8, Name="Deepak", Marks=89, BatchCode="B002"},
                };
             
            return View(students);
        }

    }
}