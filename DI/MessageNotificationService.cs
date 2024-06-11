using Microsoft.Extensions.DependencyInjection;

namespace DI;

public class MessageNotificationService(
    [FromKeyedServices(Constants.Constants.MessageServiceMail)] IMessageService messageService)
{
    private readonly IMessageService _messageService = messageService;

    public void Notify()
    {
        _messageService.SendMessage("");
    }
}