using System;
class Student : Human
{
    private char grade;

    public Student(string name, string lastName, char grade)
        : base(name, lastName)
    {
        this.grade = grade;
    }
    public char Grade
    {
        get
        {
            return this.grade;
        }
        set
        {
            if (value < 'A' || value > 'F')
            {
                throw new ArgumentException("Invalid grade! Grades must be in the range between A and F!");
            }
            this.grade = value;
        }
    }
}
