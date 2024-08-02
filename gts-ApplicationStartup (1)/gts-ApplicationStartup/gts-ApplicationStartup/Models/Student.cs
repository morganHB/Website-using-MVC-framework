using gts_ApplicationStartup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        
    }
}
