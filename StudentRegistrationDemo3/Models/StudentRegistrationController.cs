using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using StudentRegistrationDemo3.Models;

namespace StudentRegistrationDemo3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegistrationController : Controller
    {
        // POST: api/<controller>
        [HttpPost]
        public StudentRegistrationReply RegisterStudent(Student studentregd)
        {
            Console.WriteLine("In registerStudent");
            StudentRegistrationReply stdregreply = new StudentRegistrationReply();
            StudentRegistration.getInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNumber = studentregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";

            return stdregreply;
        }

        [HttpPost("InsertStudent")]
        public IActionResult InsertStudent(Student studentregd)
        {
            Console.WriteLine("In registerStudent");
            StudentRegistrationReply stdregreply = new StudentRegistrationReply();
            StudentRegistration.getInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNumber = studentregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";

            return Ok(stdregreply);
        }

        [Route("student/")]
        [HttpPost("AddStudent")]
        public JsonResult AddStudent(Student studentregd)
        {
            Console.WriteLine("In registerStudent");
            StudentRegistrationReply stdregreply = new StudentRegistrationReply();
            StudentRegistration.getInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNumber = studentregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";

            return Json(stdregreply);
        }

    }
}
