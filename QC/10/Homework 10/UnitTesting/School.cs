using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
	public class School
	{
		public School(List<Course> courses = null)
		{
			this.Courses = new List<Course>();
			if (courses != null)
			{
				this.Courses=courses;
			}
		}

		public List<Course> Courses { get; set; }

		public void AddCourse(Course course)
		{
			this.Courses.Add(course);
		}

		public void RemoveCourse(Course course)
		{
			bool courseFound = false;
			for (int i = 0; i < this.Courses.Count; i++)
			{
				if (this.Courses[i].Name == course.Name)
				{
					courseFound = true;
					this.Courses.Remove(course);
				}
			}

			if (!courseFound)
			{
				throw new ApplicationException("The course does not exist in this school!");
			}
		}
	}
}
