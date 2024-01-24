using _2802_POO.Models.Enums;

namespace _2802_POO.ContentContext;

public class Insurance
{
    public Insurance(Broker broker, DateTime contractDate, ETypeInsurance type, decimal value)
    {
        Broker = broker;
        ContractDate = contractDate;
        Type = type;
        Value = value;
    }

    public Broker Broker { get; set; }
    public DateTime ContractDate { get; set; }
    public ETypeInsurance Type { get; set; }
    public decimal Value { get; set; }

}
