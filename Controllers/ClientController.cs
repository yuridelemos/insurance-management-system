using _insurance_management_system.ContentContext;

namespace _insurance_management_system.Controllers;

public class ClientController
{
    internal List<Client> clients = new List<Client>();

    public void Register()
    {
        Console.WriteLine("======= Cadastro =======");
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("CPF/CNPJ: ");
        var registration = long.Parse(Console.ReadLine());
        Console.Write("E-mail: ");
        var email = Console.ReadLine();
        clients.Add(new Client(
            (clients.Count + 1),
            name,
            registration,
            email));
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Cliente cadastrado(a) com sucesso.");
    }
    public void List() =>
        clients
            .Select((item, index) => $"({index + 1}) - {item.Name}")
            .ToList()
            .ForEach(Console.WriteLine);

    public Client SelectClient()
    {
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("======= Seleção de Cliente =======");
        List();
        Console.WriteLine("(0) - Novo cliente");
        Console.Write("Selecione o(a) cliente que deseja: ");
        var id = int.Parse(Console.ReadLine());
        var itemAdd = clients.Find(client => client.Id == id);
        if (itemAdd != null)
            return itemAdd;
        if (id == 0)
            Register();
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
    }
}