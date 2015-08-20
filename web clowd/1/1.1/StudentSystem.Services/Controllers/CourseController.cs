using System;
using System.Linq;
using System.Web.Http;
using StudentSystem.Data.Repositories;
using StudentSystem.Models;
using StudentSystem.Services.Models;
using StudentSystem.Data;

namespace StudentSystem.Services.Controllers
{
    public class CourseController : ApiController
    {
        private IStudentSystemData data;

        public CourseController()
            : this(new StudentsSystemData())
        {

        }

        public CourseController(IStudentSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var courses = this.data.Courses.All().Select(CourseModel.FromCourse);

            return Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Create(CourseModel Course)
        {
            throw new NotImplementedException("I can't add my CourseModel as an Course :(");

            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newCourse = new CourseModel
            {
                Description = Course.Description
            };

            //Why? Why?Why?Why?Why?Why?Why?Why?!!!!!!!
            //this.data.Courses.Add((Course)newCourse);
            this.data.SaveChanges();

            Course.Id = newCourse.Id;
            return Ok(newCourse);
        }

        [HttpPut]
        public IHttpActionResult Update(Guid id, CourseModel course)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Course existingCourse = this.data.Courses.All().FirstOrDefault(a => a.Id == id);

            if (existingCourse == null)
            {
                return BadRequest("The Course does not exist");
            }

            existingCourse.Description = course.Description;
            this.data.SaveChanges();

            course.Id = existingCourse.Id;
            return Ok(course);
        }

        [HttpDelete]
        public IHttpActionResult Delete(Guid id)
        {
            var existingCourse = this.data.Courses.All().FirstOrDefault(a => a.Id == id);


            if (existingCourse == null)
            {
                return BadRequest("The Course does not exist");
            }

            this.data.Courses.Delete(existingCourse);
            this.data.SaveChanges();

            return Ok();
        }
    }
}
