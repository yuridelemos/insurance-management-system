using _insurance_management_system.ContentContext;

namespace _insurance_management_system.Controllers;

public class BrokerController
{
    internal List<Broker> brokers = new List<Broker>();

    public void Register()
    {
        var name = Console.ReadLine();
        var registration = long.Parse(Console.ReadLine());
        var email = Console.ReadLine();
        var broker = new Broker((brokers.Count+1), name, registration, email);
        brokers.Add(broker);
        Console.WriteLine("Corretora cadastrada com sucesso.");
    }
    public void List() =>
        brokers
            .Select((seg, index) => $"{index + 1}. {seg.Name}")
            .ToList()
            .ForEach(Console.WriteLine);

    public Broker SelectBroker()
    {
        Console.Write("Selecione a Corretora que deseja: ");
        var id = int.Parse(Console.ReadLine());
        var itemAdd = brokers.Find(broker => broker.Id == id);
        if (itemAdd != null)
            return itemAdd;
        else
            Console.WriteLine($"Seguradora não encontrada.");
        return SelectBroker();
    }


    public void AddBroker(Broker broker, Insurance insurance)
    {
        var itemAdd = brokers.Find(insuranceCompany => insuranceCompany.Id == broker.Id);
        if (itemAdd != null)
        {
            itemAdd.Insurances.Add(insurance);
            Console.WriteLine($"Novo seguro adicionado para {itemAdd.Name}: {insurance.Type}");
        }
        else
            Console.WriteLine($"Seguradora não encontrada.");

        foreach (var item in brokers)
        {
            Console.WriteLine($"{item.Name} - {item.Insurances.Count}");
        }
    }
}