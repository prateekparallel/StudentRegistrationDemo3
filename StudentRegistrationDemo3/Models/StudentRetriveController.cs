using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using StudentRegistrationDemo3.Models;

namespace StudentRegistrationDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRetriveController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return StudentRegistration.getInstance().getAllStudent();
        }

        [HttpGet("GetAllStudentRecords")]
        public JsonResult GetAllStudentRecords()
        {
            return Json(StudentRegistration.getInstance().getAllStudent());
        }
    }
}
