namespace DesingPatternOOP_.src.oopPrinciple.Coupling;

public class SmsSender : INotificationService
{
    public void sendNotification(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }
}
