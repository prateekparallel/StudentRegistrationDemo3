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
    public class StudentDeleteController : Controller
    {
        [Route("student/remove/{regdNum}")]
        // DELETE: api/<controller>
        [HttpDelete]
        public IActionResult DeleteStudentRecord(String regdNum)
        {
            Console.WriteLine("In deleteStudentRecord");
            return Ok(StudentRegistration.getInstance().Remove(regdNum));
        }
    }
}
