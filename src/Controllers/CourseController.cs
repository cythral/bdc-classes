using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BrekkeDanceCenter.Classes.Entities;
using BrekkeDanceCenter.Classes.Authentication;

namespace BrekkeDanceCenter.Classes.Controllers {
    [ApiController]
    [Route("/courses")]
    public class CourseController : ControllerBase {
        private DatabaseContext databaseContext;

        public CourseController(DatabaseContext databaseContext) {
            this.databaseContext = databaseContext;
        }

        [HttpGet]
        [Authenticate]
        public ActionResult<IEnumerable<Course>> ListCourses() {
            var courses = databaseContext.Courses.Include(course => course.Classes).ToList();
            return new ActionResult<IEnumerable<Course>>(courses);
        }
    }
}