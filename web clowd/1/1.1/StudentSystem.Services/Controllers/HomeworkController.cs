using StudentSystem.Data;
using StudentSystem.Models;
using StudentSystem.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentSystem.Services.Controllers
{
    public class TestController : ApiController
    {
        private IStudentSystemData data;

        public TestController()
            : this(new StudentsSystemData())
        {

        }

        public TestController(IStudentSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var courses = this.data.Tests.All().Select(TestModel.FromTest);

            return Ok(courses);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, TestModel test)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Test existingTest = this.data.Tests.All().FirstOrDefault(a => a.Id == id);

            if (existingTest == null)
            {
                return BadRequest("The Test does not exist");
            }

            existingTest.CourseId = test.CourseId;
            this.data.SaveChanges();

            test.Id = existingTest.Id;
            return Ok(test);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingTest = this.data.Tests.All().FirstOrDefault(a => a.Id == id);


            if (existingTest == null)
            {
                return BadRequest("The Test does not exist");
            }

            this.data.Tests.Delete(existingTest);
            this.data.SaveChanges();

            return Ok();
        }
    }
}
