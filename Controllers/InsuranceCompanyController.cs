using _insurance_management_system.ContentContext;

namespace _insurance_management_system.Controllers;

public class InsuranceCompanyController
{
    internal List<InsuranceCompany> insuranceCompanies = new List<InsuranceCompany>();
    public void Register()
    {
        var name = Console.ReadLine();
        var registration = long.Parse(Console.ReadLine());
        var email = Console.ReadLine();

        var company = new InsuranceCompany((insuranceCompanies.Count+1),name, registration, email);

        Console.WriteLine("Seguradora cadastrada com sucesso.");
    }
    public void List() =>
            insuranceCompanies
                .Select((seg, index) => $"{index + 1}. {seg.Name}")
                .ToList()
                .ForEach(Console.WriteLine);

    public InsuranceCompany SelectCompany()
    {
        List();
        Console.Write("Selecione a Seguradora que deseja: ");
        var id = int.Parse(Console.ReadLine());
        var itemAdd = insuranceCompanies.Find(company => company.Id == id);
        if (itemAdd != null)
            return itemAdd;
        else
            Console.WriteLine($"Seguradora não encontrada.");
        return SelectCompany();
    }


    public void AddData(InsuranceCompany company, Insurance insurance, Broker broker)
    {
        var itemAdd = insuranceCompanies.Find(item => item.Id == company.Id);
        if (itemAdd != null)
        {
            itemAdd.Brokers.Add(broker);
            itemAdd.Insurances.Add(insurance);
            Console.WriteLine($"Novo seguro adicionado para {itemAdd.Name}: {insurance.Type}");
        }
        else
            Console.WriteLine($"Seguradora não encontrada.");

        foreach (var item in insuranceCompanies)
        {
            Console.WriteLine($"{item.Name} - {item.Insurances.Count}");
        }
    }
}
