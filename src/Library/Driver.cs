namespace Library;

public class Driver : User
{
    private string vehicle;
    private string bio;
    private bool type;
    public string Vehicle
    {
        get { return vehicle; }
        set { Vehicle = value; }
    }

    public string Bio
    {
        get { return bio; }
        set { Vehicle = value; }
    }

    public bool Type
    {
        get { return type; }
        set { Type = value; }
    }
}