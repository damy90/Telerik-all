using System;
using System.Collections.Generic;

class Discipline : IComentable
{
    private string name;
    private int lecdtureCount;
    private int exersizeCount;

    public Discipline(string name, int lecdtureCount, int exersizeCount)
    {
        this.Name = name;
        this.LecdtureCount = lecdtureCount;
        this.ExersizeCount = exersizeCount;
    }

    public List<string> Comments { get; set; }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Length < 4)
                throw new ArgumentException("The name of the subject must be at least 4 characters long");
            this.name = value;
        }
    }

    public int LecdtureCount
    {
        get
        {
            return this.lecdtureCount;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Count must be non negative");
            this.lecdtureCount = value;
        }
    }

    public int ExersizeCount
    {
        get
        {
            return this.exersizeCount;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Count must be non negative");
            this.exersizeCount = value;
        }
    }

    public void AddComment(string comment)
    {
        //initialize the list if it doesn't exist yet
        if (Comments == null)
            Comments = new List<string>();
        Comments.Add(comment);
    }
}
