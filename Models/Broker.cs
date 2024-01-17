namespace _2802_POO.ContentContext;

public class Broker : User
{
    public Broker(string name, long registrationNumber, string email) : base(name, registrationNumber, email)
    {
    }

    public IList<Client> Clients { get; set; } = new List<Client>();
    public IList<Insurance> Insurances { get; set; } = new List<Insurance>();

}
