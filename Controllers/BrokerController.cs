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
        List();
        Console.Write("Selecione a Corretora que deseja: ");
        var id = int.Parse(Console.ReadLine());
        var itemAdd = brokers.Find(broker => broker.Id == id);
        if (itemAdd != null)
            return itemAdd;
        else
            Console.WriteLine($"Corretora não encontrada.");
        return SelectBroker();
    }


    public void AddData(Broker broker, Insurance insurance, Client client)
    {
        var itemAdd = brokers.Find(item => item.Id == broker.Id);
        if (itemAdd != null)
        {
            itemAdd.Clients.Add(client);
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