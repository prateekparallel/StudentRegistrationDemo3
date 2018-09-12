using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;

using StudentRegistrationDemo3.Models;

namespace StudentRegistrationDemo3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentUpdateController : Controller
    {
        // GET: api/<controller>
        [HttpPut]
        public JsonResult UpdateStudentRecord( Student stdn)
        {
            Console.WriteLine("In updateStudentRecord");
            return Json(StudentRegistration.getInstance().UpdateStudent(stdn));
        }
    }
}
