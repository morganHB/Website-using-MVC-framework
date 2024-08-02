using gts_ApplicationStartup.Models;
using System.Collections.Generic;
using Web.Models;

namespace gts_ApplicationStartup.Services
{
    public interface ITeachersService
    {
        void CreateTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int teacherId);
        Teacher GetTeacher(int teacherId);
        IEnumerable<Teacher> GetAllTeachers();
    }
}
