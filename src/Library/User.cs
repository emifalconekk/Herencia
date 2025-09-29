namespace Library;
using System.Collections.Generic;

public abstract class User
{
    private string name;
    private int id;
    private string familyname;
    private int calification;
    public static List<User> users = new List<User>();
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string FamilyName
    {
        get { return familyname; }
        set { familyname = value; }
    }

    public int Calification
    {
        get { return calification; }
        set { calification = value; }
    }

    protected User(string name, int id, string familyname, int calification)
    {
        this.name = name;
        this.id = id;
        this.familyname = familyname;
        this.calification = calification;
        users.Add(this);
    }
}