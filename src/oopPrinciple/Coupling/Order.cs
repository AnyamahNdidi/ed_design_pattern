namespace DesingPatternOOP_.src.oopPrinciple.Coupling;

public class Order
{
    private readonly INotificationService _notificationService;

    public Order(INotificationService notificationService)
    {
        this._notificationService = notificationService;
    }
    
    
    public void PlaceOrder()
    {
        _notificationService.sendNotification("Order placed successfully.");
    }
}
