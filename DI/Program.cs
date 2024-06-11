// See https://aka.ms/new-console-template for more information

using DI;
using Microsoft.Extensions.DependencyInjection;

//Console.WriteLine("Hello, World!");

var services = DependencyInjection.AddServices();

var smsService = services.GetService<IMessageService>();
var notificationService = services.GetRequiredService<MessageNotificationService>();

notificationService.Notify();

