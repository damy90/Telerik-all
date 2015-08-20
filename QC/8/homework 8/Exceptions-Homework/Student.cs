using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName,
        lastName;
    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid first name!");
            }

            this.firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid last name!");
            }

            this.lastName = value;
        }
    }
    public IList<Exam> Exams { get; set; }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        if (firstName == null)
        {
            throw new ArgumentException("Invalid first name!");
        }

        if (lastName == null)
        {
            throw new ArgumentException("Invalid last name!");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new NullReferenceException("Exams is not set!");//anything is better than chrome's "He's dead Jim!"
        }

        if (this.Exams.Count == 0)
        {
            throw new ApplicationException("The student has no exams!");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            // Cannot calculate average on missing exams
            throw new NullReferenceException("Exams is not set!");
        }

        if (this.Exams.Count == 0)
        {
            throw new ApplicationException("The student has no exams!");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
