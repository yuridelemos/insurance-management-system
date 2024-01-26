using _insurance_management_system.ContentContext;

namespace _insurance_management_system.Controllers;

public class InsuranceCompanyController : Controller<InsuranceCompany>
{
    internal List<InsuranceCompany> insuranceCompanies = new List<InsuranceCompany>();
    public void Register() => base.Register(insuranceCompanies);
    public void List() => base.List(insuranceCompanies);
    public InsuranceCompany SelectInsuranceCompany() => base.SelectItem(insuranceCompanies);

    public override void AddData(InsuranceCompany company, object entity1, object entity2)
    {
        if (entity1 is Insurance && entity2 is Broker)
        {
            Insurance insurance = (Insurance)entity1;
            Broker broker = (Broker)entity2;

            var itemAdd = insuranceCompanies.Find(item => item.Id == company.Id);
            if (itemAdd != null)
            {
                itemAdd.Brokers.Add(broker);
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
