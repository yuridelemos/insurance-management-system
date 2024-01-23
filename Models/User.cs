namespace _2802_POO.ContentContext;

public abstract class User
{

    public User(int id, string name, long registrationNumber, string email)
    {
        Id = id;
        Name = name;
        RegistrationNumber = registrationNumber;
        Email = email;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public long RegistrationNumber { get; set; }
    public string Email { get; set; }

}
