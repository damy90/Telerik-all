using System;
using System.Collections.Generic;

class SchoolClass
{
    private List<Student> students;
    private string classID;
    private List<Teacher> teachers;

    public SchoolClass(List<Student> students, string classID, List<Teacher> teachers)
    {
        this.Students = students;
        this.ClassID = classID;
        this.teachers = teachers;
    }

    public List<Student> Students
    {
        get
        {
            return this.students;
        }
        set
        {
            this.students = value;
        }
    }

    public string ClassID
    {
        get
        {
            return this.classID;
        }
        set
        {
            if (value.Length < 1)
                throw new ArgumentException("The name must be at least 1 characters long");
            this.classID = value;
        }
    }

    public List<Teacher> Teachers
    {
        get
        {
            return this.teachers;
        }
        set
        {
            this.teachers = value;
        }
    }
}
