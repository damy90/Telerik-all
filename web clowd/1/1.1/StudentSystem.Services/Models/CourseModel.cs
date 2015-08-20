using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace StudentSystem.Services.Models
{
    public class CourseModel
    {
        public static Expression<Func<Course, CourseModel>> FromCourse
        {
            get
            {
                return a => new CourseModel
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description
                };
            }
        }
        public Guid Id { get; set; }

        [Column("CourseName")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}