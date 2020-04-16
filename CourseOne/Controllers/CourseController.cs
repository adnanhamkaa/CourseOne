using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseOne.Context;
using CourseOne.Repository;

namespace CourseOne.Controllers
{
    public class CourseController : Controller
    {
        private ICourse icourse;
        public CourseController()
        {
            this.icourse = new CourseRepository(new DatabaseContext());
        }
        DatabaseContext db = new DatabaseContext();
        // GET: Course
        public ActionResult Index()
        {
            var list = icourse.listCourse();
            return View(list);
        }
    }
}