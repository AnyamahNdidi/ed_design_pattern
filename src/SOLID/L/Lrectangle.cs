using System;

namespace DesingPatternOOP_.src.SOLID.L;

public class Lrectangle : Lshape
{
    public virtual double Height { get; set; }
    public virtual double Width { get; set; }

    public override double Area => Height * Width;
}
