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
