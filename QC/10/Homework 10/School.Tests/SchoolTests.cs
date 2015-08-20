using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
	[TestClass]
	public class SchoolTests
	{
		[TestMethod]
		public void TestSetCourseList()
		{
			Course php = new Course("PHP");
			Course js = new Course("Java Script");
			List<Course> courses = new List<Course>();
			courses.Add(php);
			courses.Add(js);

			School mySchool = new School(courses);
			Assert.AreEqual(mySchool.Courses.Count, 2);
			Assert.AreEqual(mySchool.Courses[1].Name, "Java Script");
		}

		[TestMethod]
		public void TestAddCourse()
		{
			Course php = new Course("PHP");
			Course js = new Course("Java Script");
			School mySchool = new School();

			mySchool.AddCourse(php);
			mySchool.AddCourse(js);
			Assert.AreEqual(mySchool.Courses.Count, 2);
			Assert.AreEqual(mySchool.Courses[1].Name, "Java Script");
		}

		[TestMethod]
		public void TestRemoveCourse()
		{
			Course php = new Course("PHP");
			Course js = new Course("Java Script");
			School mySchool = new School();
			mySchool.AddCourse(php);
			mySchool.AddCourse(js);

			mySchool.RemoveCourse(php);
			Assert.AreEqual(mySchool.Courses.Count, 1);
			Assert.AreEqual(mySchool.Courses[0].Name, "Java Script");
		}

		[TestMethod]
		[ExpectedException(typeof(ApplicationException))]
		public void TestRemoveNonExistingCourse()
		{
			Course php = new Course("PHP");
			Course js = new Course("Java Script");
			School mySchool = new School();
			mySchool.AddCourse(js);

			mySchool.RemoveCourse(php);
		}
	}
}
