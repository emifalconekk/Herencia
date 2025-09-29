namespace Library;

public class Driver : User
{
    private string vehicle;
    private string bio;
    private bool type;
    public string Vehicle
    {
        get { return vehicle; }
        set { vehicle = value; }
    }

    public string Bio
    {
        get { return bio; }
        set { bio = value; }
    }

    public bool Type
    {
        get { return type; }
        set { type = value; }
    }

    public Driver(string name, int id, string familyname, int calification, string vehicle, string bio, bool type) :
        base(name, id, familyname, calification)
    {
        this.vehicle = vehicle;
        this.bio = bio;
        this.type = type;
    }
}