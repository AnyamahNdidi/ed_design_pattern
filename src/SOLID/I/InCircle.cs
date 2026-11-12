using System;

namespace DesingPatternOOP_.src.SOLID.I;

public class InCircle : Ishape2D
{
    public double Radius { get; set; }
    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    // public double Volume()
    // {
    //     throw new InvalidOperationException("Volume is not applicable for a 2D shape like Circle.");
    // }
}
