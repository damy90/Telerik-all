using System;
using System.Linq;

namespace School
{
	public class Student
	{
		private string name;
		private int studentID;

		private const int StudentIDMin = 10000;
		private const int StudentIDMax = 99999;

		public Student(string name, int studentID)
		{
			this.Name = name;
			this.StudentID = studentID;
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

		public int StudentID
		{
			get
			{
				return this.studentID;
			}

			set
			{
				if (value >= StudentIDMin && value <= StudentIDMax)
				{
					this.studentID = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Student Number must be in the range between 10000 and 99999!");
				}
			}
		}
	}
}
