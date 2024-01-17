using _2802_POO.Models.Enums;

namespace _2802_POO.ContentContext;

public class Insurance
{
    public InsuranceCompany Company { get; set; }
    public Broker Broker { get; set; }
    public DateTime ContractDate { get; set; }
    public ETypeInsurance Type { get; set; }
    public decimal Value { get; set; }
}
