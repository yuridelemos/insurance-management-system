using _insurance_management_system.ContentContext;

namespace _insurance_management_system.Controllers;

public class ClientController
{
    internal List<Client> clients = new List<Client>();

    public void Register()
    {
        var name = Console.ReadLine();
        var registration = long.Parse(Console.ReadLine());
        var email = Console.ReadLine();
        var Client = new Client((clients.Count + 1), name, registration, email);
        clients.Add(Client);
        Console.WriteLine("Cliente cadastrada com sucesso.");
    }
    public void List() =>
        clients
            .Select((seg, index) => $"{index + 1}. {seg.Name}")
            .ToList()
            .ForEach(Console.WriteLine);

    public Client SelectClient()
    {
        List();
        Console.Write("Selecione a Cliente que deseja: ");
        var id = int.Parse(Console.ReadLine());
        var itemAdd = clients.Find(client => client.Id == id);
        if (itemAdd != null)
            return itemAdd;
        else
            Console.WriteLine($"Cliente não encontrada.");
        return SelectClient();
    }

    public void AddData(Client client, Insurance insurance)
    {
        var itemAdd = clients.Find(item => item.Id == client.Id);
        if (itemAdd != null)
        {
            itemAdd.Insurances.Add(insurance);
            Console.WriteLine($"Novo seguro adicionado para {itemAdd.Name}: {insurance.Type}");
        }
        else
            Console.WriteLine($"Cliente não encontrada.");

        foreach (var item in clients)
        {
            Console.WriteLine($"{item.Name} - {item.Insurances.Count}");
        }
    }
}