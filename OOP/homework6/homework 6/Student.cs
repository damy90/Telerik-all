using System;

//1. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.
//Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//2. Add implementations of the ICloneable interface.
//The Clone() method should deeply copy all object's fields into a new object of type Student.
//3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

class Student:ICloneable, IComparable<Student>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public ulong SSN { get; set; }
    public string Address { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public uint Course { get; set; }
    public Faculty Fac { get; set; }
    public Specialty SpecialtyName { get; set; }
    public University UniversityName { get; set; }

    public Student(string firstName, string midleName, string lastName, ulong ssn, string address, string mobile, string email,
        uint course, Faculty fac, Specialty specialtyName, University universityName)
    {
        this.FirstName = firstName;
        this.MiddleName = midleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.Address = address;
        this.Mobile = mobile;
        this.Email = email;
        this.Course = course;
        this.Fac = fac;
        this.SpecialtyName = specialtyName;
        this.UniversityName = universityName;
    }

    //assuming SSN is unique
    public override bool Equals(object param)
    {
        // If the cast is invalid, the result will be null
        Student student = param as Student;
        if (student == null)
            return false;
        
        if (!Object.Equals(this.SSN, student.SSN))
            return false;

        return true;
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !(Student.Equals(student1, student2));
    }

    public override int GetHashCode()
    {
        return SSN.GetHashCode();
    }

    object ICloneable.Clone()  // Implicit interface implementation
    {
        return this.Clone();
    }

    public Student Clone()//todo use method from demo
    {
        Student newStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, Mobile, this.Email,
            this.Course, this.Fac, this.SpecialtyName, this.UniversityName);
        return newStudent;
    }

    public int CompareTo(Student otherStudent)
    {
        if (this.FirstName != otherStudent.FirstName)
        {
            return (string.Compare(this.FirstName, otherStudent.FirstName));
        }

        if (this.MiddleName != otherStudent.MiddleName)
        {
            return (string.Compare(this.MiddleName, otherStudent.MiddleName));
        }

        if (this.LastName != otherStudent.LastName)
        {
            return (string.Compare(this.LastName, otherStudent.LastName));
        }

        if (this.SSN != otherStudent.SSN)
        {
            return (int)(this.SSN - otherStudent.SSN);
        }

        return 0;
    }

    public override string ToString()
    {
        return String.Format("{0} {1} {2} \nSSN: {3}\nAdress: {4}\nPhone: {5}\nE-mail: {6}\nUniversitu: {7}\nFaculty: {8}\nSpecialty: {9}\nCourse: {10}",
            this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.Mobile, this.Email,this.UniversityName,
            this.Fac, this.SpecialtyName, this.Course);
    }
}
