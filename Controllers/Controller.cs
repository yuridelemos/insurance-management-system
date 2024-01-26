namespace _insurance_management_system.Controllers;

public abstract class Controller<T>
{
    internal List<T> items = new List<T>();
    public void Register()
    {
        Console.WriteLine("======= Cadastro =======");
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("CNPJ/CPF: ");
        var registration = long.Parse(Console.ReadLine());
        Console.Write("E-mail: ");
        var email = Console.ReadLine();
        items.Add((T)Activator.CreateInstance(typeof(T),
            (items.Count + 1),
            name,
            registration,
            email));
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine($"{typeof(T).Name} cadastrado(a) com sucesso.");
    }

    public void List() =>
        items
            .Select((item, index) => $"({index + 1}) - {item.GetType().GetProperty("Name").GetValue(item)}")
            .ToList()
            .ForEach(Console.WriteLine);

    public T SelectItem()
    {
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine($"======= Seleção de {typeof(T).Name} =======");
        List();
        Console.Write($"Selecione o(a) {typeof(T).Name} que deseja: ");
        var id = int.Parse(Console.ReadLine());
        var itemAdd = items.Find(item => (int)item.GetType().GetProperty("Id").GetValue(item) == id);
        if (itemAdd != null)
            return itemAdd;
        else
            Console.WriteLine($"{typeof(T).Name} não encontrado(a).");
        return SelectItem();
    }

    public abstract void AddData(T item, object entity1, object entity2);
}
