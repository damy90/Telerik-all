using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
	[TestClass]
	public class CourseTest
	{
		[TestMethod]
		public void TestCourseConstructor()
		{
			Course course = new Course("PHP");
			Assert.AreEqual("PHP", course.Name);
		}

		[TestMethod]
		public void TestAddStudent()
		{
			Student georgi = new Student("Georgi Georgiev", 12345);
			Course course = new Course("PHP");
			course.AddStudent(georgi);
			Assert.AreEqual(course.StudentsList.Count, 1);
			Assert.AreEqual(course.StudentsList[0].Name, georgi.Name);

			Student boiko = new Student("Boiko Borisov", 23456);
			course.AddStudent(boiko);
			Assert.AreEqual(course.StudentsList.Count, 2);
			Assert.AreEqual(course.StudentsList[1].Name, boiko.Name);
		}

		[TestMethod]
		[ExpectedException(typeof(ApplicationException))]
		public void TestAddSameStudents()
		{
			Student georgi = new Student("Georgi Georgiev", 12345);
			Student boiko = new Student("Georgi Georgiev", 12345);
			Course course = new Course("PHP");
			course.AddStudent(georgi);
			course.AddStudent(boiko);
		}

		[TestMethod]
		public void TestRemoveStudend()
		{
			Student georgi = new Student("Georgi Georgiev", 12345);
			Student boiko = new Student("Boiko Borisov", 23456);
			Course course = new Course("PHP");
			course.AddStudent(georgi);
			course.AddStudent(boiko);
			course.RemooveStudent(georgi);
			Assert.AreEqual(course.StudentsList.Count, 1);
			Assert.AreEqual(course.StudentsList[0].Name, boiko.Name);
		}

		[TestMethod]
		[ExpectedException(typeof(ApplicationException))]
		public void TestRemoveStudendIfNotInCourse()
		{
			Student georgi = new Student("Georgi Georgiev", 12345);
			Course course = new Course("PHP");
			course.AddStudent(georgi);
			Student boiko = new Student("Boiko Borisov", 23456);
			course.RemooveStudent(boiko);
		}

		[TestMethod]
		public void TestMaxStudentsInCourse()
		{
			int studentIDStart = 30000;
			Course course = new Course("PHP");
			int maxCount = 29;
			for (int i = 1; i <= maxCount; i++)
			{
				Student newStudent = new Student("Ivan", studentIDStart+i);
				course.AddStudent(newStudent);
			}
			Assert.AreEqual(course.StudentsList.Count, maxCount);
		}

		[TestMethod]
		[ExpectedException(typeof(ApplicationException))]
		public void TestOverMaxStudentsInCourse()
		{
			int studentIDStart = 30000;
			Course course = new Course("PHP");
			int maxCount = 29;
			for (int i = 1; i <= maxCount+1; i++)
			{
				Student newStudent = new Student("Ivan", studentIDStart + i);
				course.AddStudent(newStudent);
			}
		}
	}
}
