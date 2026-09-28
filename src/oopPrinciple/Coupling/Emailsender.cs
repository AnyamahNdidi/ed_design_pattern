namespace DesingPatternOOP_.src.oopPrinciple.Coupling;

public class Emailsender: INotificationService
{
    // public void sendEmail(string message)
    // {
    //     Console.WriteLine("Email sent: " + message);
    // }

    public void sendNotification(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}
