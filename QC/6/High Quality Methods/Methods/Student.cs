namespace Methods
{
	using System;

	public class Student
	{
        private string firstName;
        private string lastName;
        private DateTime birthday;

		public Student(string firstName, string lastName, string birthday, string otherInfo = null)
		{
			this.FirstName = firstName;
			this.LastName = lastName;

			DateTime date;
			if (!DateTime.TryParse(birthday, out date))
			{
				throw new ArgumentException("Invalid date! Try this format: 1992-03-17");
			}

			this.Birthday = date;

			this.OtherInfo = otherInfo;
		}

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                this.lastName = value;
            }
        }

        public DateTime Birthday { get; private set; }

        public string OtherInfo { get; set; }

		public bool IsOlderThan(Student other)
		{
			return this.Birthday > other.Birthday;
		}
	}
}
