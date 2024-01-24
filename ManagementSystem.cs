using _insurance_management_system.ContentContext;
using _insurance_management_system.Controllers;

class ManagementSystem
{
    private InsuranceCompanyController insuranceCompanyController;
    private BrokerController brokerController;
    private InsuranceController insuranceController;
    private ClientController clientController;

    public ManagementSystem(
        InsuranceCompanyController insuranceCompanyController,
        BrokerController brokerController,
        InsuranceController insuranceController,
        ClientController clientController)
    {
        this.insuranceCompanyController = insuranceCompanyController;
        this.brokerController = brokerController;
        this.insuranceController = insuranceController;
        this.clientController = clientController;
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("======= Sistema de Seguros =======");
            Console.WriteLine("(1) - Cadastro de Seguro");
            Console.WriteLine("(2) - Cadastro de Corretor");
            Console.WriteLine("(3) - Cadastro de Seguradora");
            Console.WriteLine("(4) - Cadastro de Cliente");
            Console.WriteLine("(5) - Lista de Seguros");
            Console.WriteLine("(6) - Lista de Corretores");
            Console.WriteLine("(7) - Lista de Seguradoras");
            Console.WriteLine("(8) - Lista de Clientes");
            Console.WriteLine("(0) - Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    insuranceController.Register();
                    break;
                case "2":
                    brokerController.Register();
                    break;
                case "3":
                    insuranceCompanyController.Register();
                    break;
                case "4":
                    clientController.Register();
                    break;
                case "5":
                    insuranceController.List();
                    break;
                case "6":
                    brokerController.List();
                    break;
                case "7":
                    insuranceCompanyController.List();
                    break;
                case "8":
                    clientController.List();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }
    public void DataLoading()
    {
        insuranceCompanyController.insuranceCompanies.Add(new InsuranceCompany(
            1,
            "Porto Seguro",
            61198164000160,
            "porto@portoseguro.com"
            ));
        insuranceCompanyController.insuranceCompanies.Add(new InsuranceCompany(
            2,
            "Mapfre",
            61074175000138,
            "mapfre@mapfreseguro.com"
            ));
        brokerController.brokers.Add(new Broker(
            1,
            "Anpla",
            61074175000138,
            "anpla@anplacorretora.com"));


    }
}
