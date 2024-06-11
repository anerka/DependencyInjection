namespace DI;

public class MessageServiceMail : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Inside Mail message service");
    }
}