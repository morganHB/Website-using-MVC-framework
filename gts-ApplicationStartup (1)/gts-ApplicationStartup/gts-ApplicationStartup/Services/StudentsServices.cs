using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

using gts_ApplicationStartup.Models;

namespace gts_ApplicationStartup.Services
{
    public class StudentsServices : IStudentsServices
    {
        private readonly DataContext _dataContext;

        public StudentsServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void CreateStudent()
        {
            var stud = new Student { StudentName = "Bill" };
            _dataContext.Students.Add(stud);
            _dataContext.SaveChanges();
        }

        // Implement other methods as needed
    }
}

