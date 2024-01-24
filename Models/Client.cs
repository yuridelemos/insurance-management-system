namespace _insurance_management_system.ContentContext;

public class Client : User
{
    public Client(int id, string name, long registrationNumber, string email)
        : base(id, name, registrationNumber, email)
    => Insurances = new List<Insurance>();

    public IList<Insurance> Insurances { get; set; } = new List<Insurance>();
    public int TotalInsurances => Insurances.Count;

}
