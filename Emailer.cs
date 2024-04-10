
public class Emailer : IContactService
{
    // Email logic...
    public void Send(string message, string name) => Console.WriteLine($"\"{message}\" was sent to {name} via email.");
}
