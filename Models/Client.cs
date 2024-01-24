namespace _2802_POO.ContentContext;

public class Client : User
{
    public Client(int id, string name, long registrationNumber, string email, Insurance insurance)
        : base(id, name, registrationNumber, email)
    {

    }
    public IList<Insurance> Insurances { get; set; } = new List<Insurance>();
    public int TotalInsurances => Insurances.Count;

}
