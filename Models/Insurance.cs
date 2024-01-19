using _2802_POO.Models.Enums;

namespace _2802_POO.ContentContext;

public class Insurance
{
    public Insurance(InsuranceCompany company, Broker broker, DateTime contractDate, ETypeInsurance type, decimal value)
    {
        Company = company;
        Broker = broker;
        ContractDate = contractDate;
        Type = type;
        Value = value;
    }

    public InsuranceCompany Company { get; set; }
    public Broker Broker { get; set; }
    public DateTime ContractDate { get; set; }
    public ETypeInsurance Type { get; set; }
    public decimal Value { get; set; }

}
