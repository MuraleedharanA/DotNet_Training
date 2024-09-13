public class User
{
    // Private fields
    private string _username;
    private string _email;
    private int _age;

    // Public properties
    public string Username
    {
        get { return _username; }
        set { _username = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    // Constructor
    public User(string username, string email, int age)
    {
        _username = username;
        _email = email;
        _age = age;
    }

    // Method to update email
    public void UpdateEmail(string newEmail)
    {
        _email = newEmail;
    }

    // Method to update age
    public void UpdateAge(int newAge)
    {
        _age = newAge;
    }

    // Method to display user details
    public void DisplayUserInfo()
    {
        System.Console.WriteLine($"Username: {_username}");
        System.Console.WriteLine($"Email: {_email}");
        System.Console.WriteLine($"Age: {_age}");
    }
}
