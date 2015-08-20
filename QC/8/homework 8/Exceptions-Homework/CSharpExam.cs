using System;

public class CSharpExam : Exam
{
    private int score;
    public int Score
    {
        get
        {
            return score;
        }
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Exam score must between 0 and 100");
            }

            score = value;
        }
    }

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public override ExamResult Check()
    {
        if (Score < 0 || Score > 100)
        {
            throw new ArgumentOutOfRangeException("Exam score must between 0 and 100");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
