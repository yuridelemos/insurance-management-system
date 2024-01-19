using _2802_POO.ContentContext;
using _2802_POO.Models.Enums;

namespace _2802_POO.Controllers
{
    public class InsuranceController
    {
        private List<Insurance> insurances = new List<Insurance>();
        public void Register()
        {
            var company = new InsuranceCompanyController();
            company.List();
            System.Console.Write("Selecione a Seguradora que deseja: ");
            var companySelect = 0; //int.Parse(Console.ReadLine());
            var broker = new BrokerController();
            broker.List();
            var brokerSelect = 0; //int.Parse(Console.ReadLine());
            var date = DateTime.Now;

            System.Console.WriteLine("(1) - Vida");
            System.Console.WriteLine("(2) - Auto");
            System.Console.WriteLine("(3) - Residencial");
            System.Console.WriteLine("(4) - Saúde");
            System.Console.WriteLine("(5) - Viagem");

            var insuranceSelect = ETypeInsurance.Life; //int.Parse(Console.ReadLine());
            var value = 100m; //decimal.Parse(Console.ReadLine());

            var porto =
                    company.insuranceCompanies.ElementAt(companySelect).Name;
            broker.brokers.ElementAt(brokerSelect);

            var insurance = new Insurance(
                company.insuranceCompanies.ElementAt(companySelect),
                broker.brokers.ElementAt(brokerSelect),
                date,
                insuranceSelect,
                value);
            System.Console.WriteLine("Seguradora cadastrada com sucesso.");
        }
        public void List()
        {
            foreach (var item in insurances)
            {
                System.Console.WriteLine(item.Company);
                System.Console.WriteLine(item.Broker);
                System.Console.WriteLine(item.ContractDate);
                System.Console.WriteLine(item.Type);
                System.Console.WriteLine(item.Value);
            }
        }
    }
}