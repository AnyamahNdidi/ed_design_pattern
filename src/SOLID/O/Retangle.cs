namespace DesingPatternOOP_;
using DesingPatternOOP_.src.solid.O;
public class Retangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override double CalculateArea()
    {
        return Length * Width;
    }

}
