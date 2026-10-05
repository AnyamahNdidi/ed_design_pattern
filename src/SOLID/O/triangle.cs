namespace DesingPatternOOP_;
using DesingPatternOOP_.src.solid.O;
public class Triangle: Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

}
