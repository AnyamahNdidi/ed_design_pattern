namespace DesingPatternOOP_.src.oopPrinciple.Compositions;
using DesingPatternOOP;
public class Carcom
{
    private Engine engine = new Engine();
    private Wheels wheels= new Wheels();
    private Chassis chassis = new Chassis();
    private Seats seats = new Seats();

    public void startCar()
    {
        engine.start();
        wheels.Rotations();
        chassis.Support();
        seats.sit();
    }

  
}
