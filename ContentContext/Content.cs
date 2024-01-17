namespace _2802_POO.ContentContext;

public abstract class Content
{

    public Content()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Time { get; set; }
    public string Url { get; set; }

}
