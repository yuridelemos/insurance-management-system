using _2802_POO.ContentContext;

namespace _2802_POO.Controllers
{
    public class BrokerController
    {
        internal List<Broker> brokers = new List<Broker>();

        public void Register()
        {
            var name = Console.ReadLine();
            var registration = long.Parse(Console.ReadLine());
            var email = Console.ReadLine();

            var broker = new Broker(name, registration, email);
            brokers.Add(broker);

            name = "Mapfre";
            registration = 61074175000138;
            email = "mapfre@mapfreseguro.com";
            broker = new Broker(name, registration, email);
            brokers.Add(broker);
            System.Console.WriteLine("Corretora cadastrada com sucesso.");
        }
        public void List()
        {
            foreach (var item in brokers)
            {
                System.Console.WriteLine(item.Name);
                System.Console.WriteLine(item.RegistrationNumber);
            }
        }

    }
}