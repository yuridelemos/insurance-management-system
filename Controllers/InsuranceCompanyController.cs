using _insurance_management_system.ContentContext;

namespace _insurance_management_system.Controllers;

public class InsuranceCompanyController
{
    internal List<InsuranceCompany> insuranceCompanies = new List<InsuranceCompany>();
    public void Register()
    {
        Console.WriteLine("======= Cadastro =======");
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("CNPJ: ");
        var registration = long.Parse(Console.ReadLine());
        Console.Write("E-mail: ");
        var email = Console.ReadLine();
        insuranceCompanies.Add(new InsuranceCompany((
            insuranceCompanies.Count + 1),
            name,
            registration,
            email));
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Seguradora cadastrada com sucesso.");
    }
    public void List() =>
            insuranceCompanies
            .Select((item, index) => $"({index + 1}) - {item.Name}")
                .ToList()
                .ForEach(Console.WriteLine);

    public InsuranceCompany SelectCompany()
    {
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine("======= Seleção de Seguradora =======");
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
    }
}
