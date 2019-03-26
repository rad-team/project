using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace Assignment.Controllers
{
    [Authorize]
    public class StudentController : ApiController
    {
        Student[] student = new Student[] {
            new Student { Id = 1, Name = "Jane Doe" },
            new Student { Id = 2, Name = "John Doe" }
        };

        [ResponseType(typeof(Lecture))]
        public IHttpActionResult Get()
        {
            return Ok(student[0]);
        }
    }
}