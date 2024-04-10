
public class TextMessager : IContactService
{
    // Text message logic...
    public void Send(string message, string name) => Console.WriteLine($"\"{message}\" was sent to {name} via text message.");
}
