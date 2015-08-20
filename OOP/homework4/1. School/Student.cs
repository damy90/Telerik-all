using System;
using System.Collections.Generic;

//TO DO: make sure class numbers are unique

class Student : Person, IComentable
{
    private int classNumber;

    public Student(string name, int classnumber)
        : base(name)
    {
        this.ClassNumber = classnumber;
        this.Comments = new List<string>();
    }

    public List<string> Comments { get; set; }
    public int ClassNumber
    {
        get
        {
            return this.classNumber;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Class number must be a non negative number");
            this.classNumber = value;
        }
    }

    public void AddComment(string comment)
    {
        if (comment.Length < 3)
            throw new ArgumentException("The comment must be at least 3 characters long");
        Comments.Add(comment);
    }
}
