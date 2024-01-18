using _2802_POO.ContentContext;
using _2802_POO.Controllers;

var porto = new InsuranceCompany
(
    "Porto Seguro",
    61198164000160,
    "porto@portoseguro.com"
);

var mapfre = new InsuranceCompany
(
    "Mapfre",
    61074175000138,
    "mapfre@mapfreseguro.com"
);

var teste = new BrokerController();
teste.Register();
teste.List();

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