using _insurance_management_system.ContentContext;
using _insurance_management_system.Models.Enums;

namespace _insurance_management_system.Controllers;

public class InsuranceController
{
    private InsuranceCompanyController CompanyController;
    private BrokerController BrokerController;
    private ClientController ClientController;
    private List<Insurance> insurances = new List<Insurance>();
    public InsuranceController(
        InsuranceCompanyController companyController,
        BrokerController brokerController,
        ClientController clientController)
    {
        CompanyController = companyController;
        BrokerController = brokerController;
        ClientController = clientController;
    }
    public void Register()
    {
        var clientChoice = ClientController.SelectClient();
        var brokerChoice = BrokerController.SelectBroker();
        var companyChoice = CompanyController.SelectInsuranceCompany();
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine("======= Escolha de Seguro =======");
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
        Thread.Sleep(1000);
        Console.Clear();
        BrokerController.AddData(brokerChoice, insurance, clientChoice);
        CompanyController.AddData(companyChoice, insurance, brokerChoice);
        ClientController.AddData(clientChoice, insurance, null);
    }
    public void List()
    {
        foreach (var item in insurances)
            Console.WriteLine(
                $"{item.Broker.Name} - " +
                $"{item.ContractDate} - " +
                $"{item.Type} - R$ " +
                $"{item.Value
                .ToString("N2", System.Globalization
                .CultureInfo
                .InvariantCulture)}");
    }
}