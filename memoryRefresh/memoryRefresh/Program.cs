namespace memoryRefresh;

interface IMessage 
{
    public string Title { get; set; }
    public string Body { get; set; }

    public void Send();
}

class EmailMessage : IMessage
{
    public string Title { get; set; } 
    public string Body { get; set; }

    public void Send()
    {
        Console.WriteLine("Message Yo");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Body: {Body}");
    }
}

class FileMessage : IMessage
{
    public string Title { get; set; }
    public string Body { get; set; }

    public void Send()
    {
        Console.WriteLine("Message Yo");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Body: {Body}");
    }
}
