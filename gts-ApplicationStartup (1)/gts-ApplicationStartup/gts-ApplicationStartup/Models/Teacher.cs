using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

namespace gts_ApplicationStartup.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string Subject { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}