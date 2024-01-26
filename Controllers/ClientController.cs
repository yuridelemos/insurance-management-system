using _insurance_management_system.ContentContext;

namespace _insurance_management_system.Controllers;

public class ClientController : Controller<Client>
{
    internal List<Client> clients = new List<Client>();

    public void Register() => base.Register();
    public void List() => base.List();
    public Client SelectClient() => base.SelectItem();

    public override void AddData(Client client, object entity1, object entity2)
    {
        if (entity1 is Insurance)
        {
            Insurance insurance = (Insurance)entity1;

            var itemAdd = clients.Find(item => item.Id == client.Id);
            if (itemAdd != null)
            {
                itemAdd.Insurances.Add(insurance);
                Console.WriteLine($"Novo seguro adicionado para {itemAdd.Name}: {insurance.Type}");
            }
            else
            {
                Console.WriteLine($"Cliente não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Tipo de entidade inválido para AddData.");
        }
    }
}