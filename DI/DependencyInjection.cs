using Microsoft.Extensions.DependencyInjection;

namespace DI;

public static class DependencyInjection
{
    public static ServiceProvider AddServices()
    {
        var serviceProvider = new ServiceCollection()
         .AddKeyedSingleton<IMessageService, MessageServiceSms>(Constants.Constants.MessageServiceSms)
         .AddKeyedSingleton<IMessageService, MessageServiceMail>(Constants.Constants.MessageServiceMail)
         .AddSingleton<MessageNotificationService>()
         .BuildServiceProvider();

        return serviceProvider;
    }
}
