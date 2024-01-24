namespace _insurance_management_system.ContentContext;

public class Broker : User
{
    public Broker(int id, string name, long registrationNumber, string email)
    : base(id, name, registrationNumber, email)
    {
        Clients = new List<Client>();
        Insurances = new List<Insurance>();
    }

    public IList<Client> Clients { get; set; } = new List<Client>();
    public IList<Insurance> Insurances { get; set; } = new List<Insurance>();

}
