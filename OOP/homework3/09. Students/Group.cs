//16. Create a class Group with properties GroupNumber and DepartmentName
class Group
{
    public int GroupNumber { get; private set; }
    public string DepartmentName { get; private set; }

    public Group(int groupNumber, string departmentName)
    {
        this.GroupNumber = groupNumber;
        this.DepartmentName = departmentName;
    }
}
