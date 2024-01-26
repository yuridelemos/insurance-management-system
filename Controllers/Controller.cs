namespace _insurance_management_system.Controllers;

public abstract class Controller<T>
{
    public void Register(List<T> values)
    {
        Console.WriteLine("======= Cadastro =======");
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("CNPJ/CPF: ");
        var registration = long.Parse(Console.ReadLine());
        Console.Write("E-mail: ");
        var email = Console.ReadLine();
        values.Add((T)Activator.CreateInstance(typeof(T),
            (values.Count + 1),
            name,
            registration,
            email));
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine($"{typeof(T).Name} cadastrado(a) com sucesso.");
    }

    public void List(List<T> values) =>
        values
            .Select((value, index) => $"({index + 1}) - {value.GetType().GetProperty("Name").GetValue(value)}")
            .ToList()
            .ForEach(Console.WriteLine);

    public T SelectItem(List<T> values)
    {
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine($"======= Seleção de {typeof(T).Name} =======");
        List(values);
        Console.Write($"Selecione o(a) {typeof(T).Name} que deseja: ");
        var id = int.Parse(Console.ReadLine());
        var itemAdd = values.Find(item => (int)item.GetType().GetProperty("Id").GetValue(item) == id);
        if (itemAdd != null)
            return itemAdd;
        else
            Console.WriteLine($"{typeof(T).Name} não encontrado(a).");
        return default(T);
    }

    public abstract void AddData(T item, object entity1, object entity2);
}
