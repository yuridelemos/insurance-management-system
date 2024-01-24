namespace _2802_POO.ContentContext;

public class Broker : User
{
    public Broker(int id, string name, long registrationNumber, string email)
    : base(id, name, registrationNumber, email)
    {
    }

    public IList<Client> Clients { get; set; } = new List<Client>();
    public IList<Insurance> Insurances { get; set; } = new List<Insurance>();

}
