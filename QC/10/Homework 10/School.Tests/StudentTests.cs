using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Знам че теста за грешка при задаване на еднакви номера не минава

namespace School.Tests
{
	[TestClass]
	public class StudentTests
	{
		[TestMethod]
		public void NameSet()
		{
			string name = "Georgi Georgiev";
			int studentID = 12345;
			Student student = new Student(name, studentID);
			Assert.AreEqual(student.Name, "Georgi Georgiev");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void NameNull()
		{
			string name = null;
			int studentID = 12345;
			Student student = new Student(name, studentID);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void NameEmpty()
		{
			string name = "";
			int studentID = 12345;
			Student student = new Student(name, studentID);
		}

		[TestMethod]
		public void StudentIDSet()
		{
			string name = "Georgi Georgiev";
			int studentID = 12345;
			Student student = new Student(name, studentID);
			Assert.AreEqual(student.StudentID, studentID);
		}

		[TestMethod]
		[ExpectedException(typeof(ApplicationException))]
		public void StudentIDUnique()
		{
			string name = "Georgi Georgiev";
			int studentID = 12345;
			Student student = new Student(name, studentID);

			string name2 = "Rosen Petrov";
			int studentID2 = 12345;
			Student student2 = new Student(name2, studentID2);
		}

		[TestMethod]
		public void StudentIDRange()
		{
			string name = "Georgi Georgiev";
			int studentID = 10000;
			Student student = new Student(name, studentID);
			Assert.AreEqual(student.StudentID, studentID);

			string name2 = "Rosen Petrov";
			int studentID2 = 99999;
			Student student2 = new Student(name2, studentID2);
			Assert.AreEqual(student2.StudentID, studentID2);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void StudentIDUotOfRangeGreater()
		{
			string name = "Georgi Georgiev";
			int studentID = 100000;
			Student student = new Student(name, studentID);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void StudentIDUotOfRangeSmaller()
		{
			string name = "Georgi Georgiev";
			int studentID = 9999;
			Student student = new Student(name, studentID);
		}
	}
}
