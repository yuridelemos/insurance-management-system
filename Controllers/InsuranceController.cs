using _2802_POO.ContentContext;
using _2802_POO.Models.Enums;

namespace _2802_POO.Controllers
{
    public class InsuranceController
    {
        private InsuranceCompanyController CompanyController;
        private BrokerController BrokerController;
        private List<Insurance> insurances = new List<Insurance>();
        public InsuranceController(
            InsuranceCompanyController companyController,
            BrokerController brokerController)
        {
            CompanyController = companyController;
            BrokerController = brokerController;
        }
        public void Register()
        {
            BrokerController.List();
            var brokerChoice = BrokerController.SelectBroker();
            CompanyController.List();
            Console.Write("Selecione a Seguradora que deseja: ");
            int companyChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("(1) - Vida");
            Console.WriteLine("(2) - Auto");
            Console.WriteLine("(3) - Residencial");
            Console.WriteLine("(4) - Saúde");
            Console.WriteLine("(5) - Viagem");
            Console.Write("Digite o tipo de seguro: ");
            ETypeInsurance insuranceSelect;
            if (Enum.TryParse(Console.ReadLine(), out insuranceSelect) && Enum.IsDefined(typeof(ETypeInsurance), insuranceSelect))
                Console.WriteLine($"Você escolheu: {insuranceSelect}");
            else
                Console.WriteLine("Opção inválida.");
            Console.Write("Digite o valor de seguro: ");
            var value = decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            var date = DateTime.Now;

            var insurance = new Insurance(
                brokerChoice,
                date,
                insuranceSelect,
                value
            );
            insurances.Add(insurance);
            CompanyController.AddInsurance(companyChoice, insurance);
            BrokerController.AddBroker(brokerChoice, insurance);
        }
        public void List()
        {
            foreach (var item in insurances)
            {
                Console.WriteLine(item.Broker.Name);
                Console.WriteLine(item.ContractDate);
                Console.WriteLine(item.Type);
                Console.WriteLine(item.Value.ToString("N2", System.Globalization.CultureInfo.InvariantCulture));
            }
        }
    }
}