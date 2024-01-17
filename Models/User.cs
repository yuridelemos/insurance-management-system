namespace _2802_POO.ContentContext;

public abstract class User
{

    public User(string name, long registrationNumber, string email)
    {
        Id = Guid.NewGuid();
        Name = name;
        RegistrationNumber = registrationNumber;
        Email = email;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public long RegistrationNumber { get; set; }
    public string Email { get; set; }

}
