using _2802_POO.ContentContext;
using Microsoft.VisualBasic;

namespace _2802_POO.Controllers;

public class InsuranceCompanyController
{
    internal List<InsuranceCompany> insuranceCompanies = new List<InsuranceCompany>();
    public void Register()
    {
        var name = Console.ReadLine();
        var registration = long.Parse(Console.ReadLine());
        var email = Console.ReadLine();

        var company = new InsuranceCompany(name, registration, email);
        insuranceCompanies.Add(company);
        System.Console.WriteLine("Seguradora cadastrada com sucesso.");
    }
    public void List() =>
            insuranceCompanies
                .Select((seg, index) => $"{index + 1}. {seg.Name}")
                .ToList()
                .ForEach(Console.WriteLine);
}
