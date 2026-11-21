
using Microsoft.AspNetCore.Mvc;
using StudentCourseRegistration.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentCourseRegistration.Controllers
{
    public class StudentController : Controller
    {
        // List to store student records
        static List<Student> students = new List<Student>();

        // Display Student List
        public IActionResult Index()
        {
            return View(students);
        }

        // Open Registration Form
        public IActionResult Create()
        {
            return View();
        }

        // Receive and Save Student Details
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                s.Id = students.Count + 1;

                students.Add(s);

                return RedirectToAction("Index");
            }

            return View(s);
        }

        // Display Student Details
        public IActionResult Details(int id)
        {
            Student s = students.FirstOrDefault(x => x.Id == id);

            if (s == null)
            {
                return NotFound();
            }

            return View(s);
        }
    }
}
