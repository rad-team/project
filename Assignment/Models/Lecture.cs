using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int Lecturer { get; set; }
        public List<int> Students { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Location { get; set; }
        public Dictionary<int,bool> Role { get; set; }

    }
}