using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
	public class Course
	{
		private const int MaxStudentsCount = 29;

		private readonly List<Student> studentsList;
		private string name;

		public Course(string name)
		{
			this.Name = name;
			this.studentsList = new List<Student>();
		}

		public string Name
		{
			get
			{
				return this.name;
			}

			set
			{
				if (value != null && value != string.Empty)
				{
					this.name = value;
				}
				else
				{
					throw new ArgumentNullException("Name cannot be null or empty!");
				}
			}
		}

		public List<Student> StudentsList
		{
			get
			{
				return this.studentsList;
			}
		}

		public void AddStudent(Student student)
		{
			if (this.FindStudent(student) != -1)
			{
				throw new ApplicationException("The student is already signed in!");
			}

			if (this.studentsList.Count < MaxStudentsCount)
			{
				this.studentsList.Add(student);
			}
			else
			{
				throw new ApplicationException("This course is full!");
			}
		}

		public void RemooveStudent(Student student)
		{
			if (this.FindStudent(student) == -1)
			{
				throw new ApplicationException("Student not found!");
			}

			this.studentsList.Remove(student);
		}

		private int FindStudent(Student student)
		{
			for (int i = 0; i < this.studentsList.Count; i++)
			{
				if (this.studentsList[i].StudentID == student.StudentID)
				{
					return i;
				}
			}

			return -1;
		}
	}
}
