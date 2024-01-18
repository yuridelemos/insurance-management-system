using _2802_POO.ContentContext;

namespace _2802_POO.Controllers
{
    public class InsuranceController
    {
        private List<Insurance> insurances = new List<Insurance>();
        public void Register()
        {
            var company = new InsuranceCompanyController();
            company.List();
            var date = DateTime.Now;
            System.Console.WriteLine("Seguradora cadastrada com sucesso.");
        }
        public void List()
        {

        }
    }
}