namespace _2802_POO.ContentContext;

public class InsuranceCompany : User
{
    public InsuranceCompany(string name, long registrationNumber, string email) : base(name, registrationNumber, email)
    => Insurances = new List<Insurance>();

    public IList<Broker> Brokers { get; set; } = new List<Broker>();
    public IList<Insurance> Insurances { get; set; } = new List<Insurance>();
}
