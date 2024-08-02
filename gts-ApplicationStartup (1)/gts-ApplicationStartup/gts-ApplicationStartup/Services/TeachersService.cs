using gts_ApplicationStartup.Models;
using gts_ApplicationStartup.Services;
using System.Collections.Generic;
using System.Linq;
using Web.Models;

namespace Web.Services
{
    public class TeachersService : ITeachersService
    {
        private readonly DataContext _context;

        public TeachersService(DataContext context)
        {
            _context = context;
        }

        public void CreateTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _context.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteTeacher(int teacherId)
        {
            var teacher = _context.Teachers.Find(teacherId);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
            }
        }

        public Teacher GetTeacher(int teacherId)
        {
            return _context.Teachers.Find(teacherId);
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }
    }
}
