using System.Formats.Tar;

public class Program
{
    public static void Main()
    {

        StudentGroup group = new StudentGroup("CSC 350H", 4);

        Console.WriteLine($"Group Name: {group.getGRoupName()}");


        group.AddMember(4);
        group.DisplayGroup();
    }
}

public class StudentGroup
{
    private string GroupName;
    private int NumberOfMembers;
    private string[] StudentNames;

    public StudentGroup(string groupName, int numOfMembers)
    {
        GroupName = groupName;
        NumberOfMembers = numOfMembers;
    }
    public void AddMember(int numOfMembers)
    {
        StudentNames = new string[numOfMembers];

        for (int i = 0; i < numOfMembers; i++)
        {
            Console.Write($"Please enter name #{i + 1} for your group:\n");
            StudentNames[i] = Console.ReadLine();
        }

    }
    public string RetrieveMember(int index)
    {
        return StudentNames[index];
    }
    public string getGRoupName()
    { return GroupName; }

    public void DisplayGroup()
    {
        Console.WriteLine($" Group: {GroupName}\nMembers:\n");
        for (int i = 0; i<NumberOfMembers; i++) {
            Console.WriteLine(StudentNames[i]);
        }
    }
}