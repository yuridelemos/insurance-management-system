namespace _insurance_management_system.ContentContext;

public class InsuranceCompany : User
{

    public InsuranceCompany(int id, string name, long registrationNumber, string email)
        : base(id, name, registrationNumber, email)
    {
        Brokers = new List<Broker>();
        Insurances = new List<Insurance>();
    }

    public IList<Broker> Brokers { get; set; } = new List<Broker>();
    public IList<Insurance> Insurances { get; set; } = new List<Insurance>();
}
