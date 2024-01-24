using _insurance_management_system.ContentContext;
using _insurance_management_system.Controllers;


ClientController clientController = new ClientController();
BrokerController brokerController = new BrokerController();
InsuranceCompanyController insuranceCompanyController = new InsuranceCompanyController();
InsuranceController insuranceController = new InsuranceController(insuranceCompanyController, brokerController, clientController);

ManagementSystem managementSystem = new ManagementSystem(
    insuranceCompanyController,
    brokerController,
    insuranceController,
    clientController);

managementSystem.DataLoading();
managementSystem.Run();
public class DataContext<B, C, I, IC>
    where B : Broker
    where C : Client
    where I : Insurance
    where IC : InsuranceCompany
{
    public void Save(B broker)
    {
        // var item = new InsuranceCompany();
    }
    public void List(B broker)
    {

    }
    public void Save(C client)
    {

    }
    public void List(C client)
    {

    }
    public void Save(I insurance)
    {

    }
    public void List(I insurance)
    {

    }
    public void Save(IC insuranceCompany)
    {

    }
    public void List(IC insuranceCompany)
    {

    }
}