using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace StudentSystem.Services.Models
{
    public class TestModel
    {
        public static Expression<Func<Test, TestModel>> FromTest
        {
            get
            {
                return a => new TestModel
                {
                    Id = a.Id,
                    CourseId = a.CourseId,
                };
            }
        }
        public int Id { get; set; }

        //public virtual ICollection<Student> Students { get; set; }

        public virtual Guid CourseId { get; set; }
    }
}