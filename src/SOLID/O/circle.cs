namespace DesingPatternOOP_;
using DesingPatternOOP_.src.solid.O;

public class circle:Shape
{       public double radius { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

}
