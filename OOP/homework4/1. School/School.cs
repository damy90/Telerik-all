using System.Collections.Generic;

class School
{
    private List<SchoolClass> schoolClasses;
    public School(List<SchoolClass> schoolClasses)
    {
        this.SchoolClasses = schoolClasses;
    }
    public List<SchoolClass> SchoolClasses
    {
        get
        {
            return this.schoolClasses;
        }
        set
        {
            this.schoolClasses = value;
        }
    }
}
