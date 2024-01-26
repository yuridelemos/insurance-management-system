using _insurance_management_system.ContentContext;

namespace _insurance_management_system.Controllers;

public class BrokerController : Controller<Broker>
{
    internal List<Broker> brokers = new List<Broker>();

    public void Register() => base.Register();
    public void List() => base.List();
    public Broker SelectBroker() => base.SelectItem();

    public override void AddData(Broker broker, object entity1, object entity2)
    {
        if (entity1 is Insurance && entity2 is Client)
        {
            Insurance insurance = (Insurance)entity1;
            Client client = (Client)entity2;

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
        else
        {
            Console.WriteLine("Tipos de entidades inválidos para AddData.");
        }
    }
}