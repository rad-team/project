using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Assignment.Models;

namespace Assignment.Controllers
{
    [Authorize]
    public class LectureController : ApiController
    {
        readonly Lecture[] lectures = new Lecture[] {
            new Lecture { Id = 1, Name = "Maths", Location="D2010", StartTime="2019-09-29T09:00:00", EndTime="2019-09-29T11:00:00", Lecturer=1, Students=new List<int>(){ 1, 2 }, Role=null },
            new Lecture { Id = 2, Name = "RAD", Location="D2012", StartTime="2019-09-29T11:00:00", EndTime="2019-09-29T12:00:00", Lecturer=2, Students=new List<int>(){ 1, 2 }, Role=null  }
        };


        [ResponseType(typeof(Lecture))]
        public IHttpActionResult Get()
        {
            return Ok(lectures[0]);
        }
    }
}
