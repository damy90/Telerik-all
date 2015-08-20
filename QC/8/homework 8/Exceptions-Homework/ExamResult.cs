using System;

public class ExamResult
{
    private int grade,
        minGrade,
        maxGrade;
    private string comments;

    public int Grade
    {
        get
        {
            return grade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade must be a positive number!");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return minGrade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade must be a positive number!");
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return maxGrade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade must be a positive number!");
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return comments;
        }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Comments cannot be empty");
            }

            this.comments = value;
        }
    }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
