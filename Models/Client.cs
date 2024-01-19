namespace _2802_POO.ContentContext;

public class Client : User
{
    public Client(string name, long registrationNumber, string email, Insurance insurance)
        : base(name, registrationNumber, email)
    {

    }
    public IList<Insurance> Insurances { get; set; } = new List<Insurance>();
    public int TotalInsurances => Insurances.Count;

}
