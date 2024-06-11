namespace DI;

public class MessageServiceSms : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Inside SMS message service");
    }
}