using _2802_POO.ContentContext;
using Microsoft.VisualBasic;

namespace _2802_POO.Controllers;

public class InsuranceCompanyController
{
    internal List<InsuranceCompany> insuranceCompanies = new List<InsuranceCompany>();
    public void Register()
    {
        // var name = Console.ReadLine();
        // var registration = long.Parse(Console.ReadLine());
        // var email = Console.ReadLine();

        // var company = new InsuranceCompany(name, registration, email);
        var company = new InsuranceCompany
            (
                1,
                "Porto Seguro",
                61198164000160,
                "porto@portoseguro.com"
            );
        insuranceCompanies.Add(company);
        company = new InsuranceCompany
            (
                2,
                "Mapfre",
                61074175000138,
                "mapfre@mapfreseguro.com"
            );
        insuranceCompanies.Add(company);

        System.Console.WriteLine("Seguradora cadastrada com sucesso.");
    }
    public void List() =>
            insuranceCompanies
                .Select((seg, index) => $"{index + 1}. {seg.Name}")
                .ToList()
                .ForEach(Console.WriteLine);

    public void AddInsurance(int id, Insurance insurance)
    {
        var itemAdd = insuranceCompanies.Find(insuranceCompany => insuranceCompany.Id == id);
        if (itemAdd != null)
        {
            itemAdd.Insurances.Add(insurance);
            Console.WriteLine($"Novo seguro adicionado para {itemAdd.Name}: {insurance.Type}");
        }
        else
            Console.WriteLine($"Seguradora não encontrada.");

        foreach (var item in insuranceCompanies)
        {
            System.Console.WriteLine($"{item.Name} - {item.Insurances.Count}");
        }
    }
}
