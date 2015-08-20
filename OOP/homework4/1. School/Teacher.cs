using System.Collections.Generic;

class Teacher : Person, IComentable
{
    private List<Discipline> disciplines;

    public Teacher(string name, List<Discipline> disciplines)
        : base(name)
    {
        this.Disciplines = disciplines;
    }

    public List<string> Comments { get; set; }

    public List<Discipline> Disciplines
    {
        get
        {
            return this.disciplines;
        }
        set
        {

            this.disciplines = value;
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
