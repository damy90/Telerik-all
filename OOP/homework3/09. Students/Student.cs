//9. Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
using System.Collections.Generic;

class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string FN { get; private set; }
    public string Tel { get; private set; }
    public string Email { get; private set; }
    public List<float> Marks { get; private set; }
    public int GroupNumber { get; private set; }

    public Student(string firstName, string lastName, string fN, string tel, string email, List<float> marks, int groupNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.FN = fN;
        this.Tel = tel;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;
    }
}