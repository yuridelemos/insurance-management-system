using _insurance_management_system.ContentContext;

namespace _insurance_management_system.Controllers;

public class BrokerController
{
    internal List<Broker> brokers = new List<Broker>();

    public void Register()
    {
        Console.WriteLine("======= Cadastro =======");
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("CNPJ: ");
        var registration = long.Parse(Console.ReadLine());
        Console.Write("E-mail: ");
        var email = Console.ReadLine();
        brokers.Add(new Broker((
            brokers.Count + 1),
            name,
            registration,
            email));
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Corretora cadastrado(a) com sucesso.");
    }
    public void List() =>
        brokers
            .Select((item, index) => $"({index + 1}) - {item.Name}")
            .ToList()
            .ForEach(Console.WriteLine);

    public Broker SelectBroker()
    {
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine("======= Seleção de Corretora =======");
        List();
        Console.Write("Selecione o(a) Corretora que deseja: ");
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
    }
}