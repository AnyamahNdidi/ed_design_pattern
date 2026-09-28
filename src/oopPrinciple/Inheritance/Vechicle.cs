
namespace _src.Inheritance;

public class Vechicle
{
    public string Brand {get; set;}
    public string Model {get; set;}
    public int Year {get; set;}

   public void Start()
   {
        System.Console.WriteLine("Vechile is starting...");
   }

   public void Stop()
   {
        System.Console.WriteLine("Vechile is stopping...");
   }

}