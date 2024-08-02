using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gts_ApplicationStartup.Services;

namespace gts_ApplicationStartup.Controllers
{
    public class HomeController : Controller
    {
        #region Private Fields

        private IStudentsServices _studentServices;

        #endregion

        #region ctor
        public HomeController(IStudentsServices studentsServices)
        {
            _studentServices = studentsServices;
        }
        #endregion

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            //_studentServices.CreateStudent();
            return View();
        }
    }
}

