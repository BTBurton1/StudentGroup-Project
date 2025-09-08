
using System.Formats.Tar;

public class Program
{
    public static void Main()
    {
        
        StudentGroup group = new StudentGroup("CSC 350H", 4);
        
        Console.WriteLine($"Group Name: {group.getGRoupName()}");
        group.DisplayGroup();
    }
}

public class StudentGroup
{
    private string GroupName;
    private int NumberOfMembers;
    private string[] NumofStudents;

    public StudentGroup(string groupName, int numOfMembers)
    {
        GroupName = groupName;
        NumberOfMembers = numOfMembers;
    }
    // public AddMember(int numOfMembers)
    // {
    //     NumofStudents = new string [numOfMembers];
    // }
    // public RetrieveMember()
    // {

    // }
    public string getGRoupName()
    { return GroupName; }

    public void DisplayGroup()
    {
        Console.WriteLine($" Group: {GroupName}");
    }
}
