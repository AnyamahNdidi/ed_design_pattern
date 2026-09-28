

using System.ComponentModel;

namespace _src.oopPrinciple.Abstractions;

class EmailService
{
    public void SendEmail()
    {
        // Logic to send email
        Connect();
        Authenticate();
        System.Console.WriteLine($"Sending email....");
        Disconnect();
    }

    private void Connect()
    {
        System.Console.WriteLine("Connecting to email server...");    
    }

    private void Authenticate()
    {
        System.Console.WriteLine("Authenticating...");
    }

    private void Disconnect()
    {
        System.Console.WriteLine("Disconnecting from email server...");
    }
    
}