using System.Linq;
using System.Net;
using System.Web.Mvc;
using gts_ApplicationStartup.Models;
using gts_ApplicationStartup.Services;
using System.Data.Entity;
using Web.Models;

namespace gts_ApplicationStartup.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeachersService _teachersService;
        private DataContext db = new DataContext();

        public TeachersController(ITeachersService teachersService)
        {
            _teachersService = teachersService;
        }

        // GET: Teachers
        public ActionResult Index()
        {
            var teachers = _teachersService.GetAllTeachers();
            return View(teachers);
        }

        // GET: Teachers/Details/5
        public ActionResult Details(int id)
        {
            var teacher = db.Teachers.Include(t => t.Students).FirstOrDefault(t => t.TeacherID == id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // GET: Teachers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeacherID,TeacherName,Subject")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _teachersService.CreateTeacher(teacher);
                return RedirectToAction("Index");
            }

            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public ActionResult Edit(int id)
        {
            var teacher = _teachersService.GetTeacher(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeacherID,TeacherName,Subject")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _teachersService.UpdateTeacher(teacher);
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        // GET: Teachers/Delete/5
        public ActionResult Delete(int id)
        {
            var teacher = _teachersService.GetTeacher(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _teachersService.DeleteTeacher(id);
            return RedirectToAction("Index");
        }
    }
}

