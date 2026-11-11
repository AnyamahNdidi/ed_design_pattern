using System;

namespace DesingPatternOOP_.src.SOLID.L;



public class Lsquare : Lshape
{
    public double SideLength {set; get;}
    public override double Area => SideLength * SideLength;
}


//WRONG  WAY 
// public class Lsquare : Lrectangle 
//     {
//     public override double Width { 
//         get => base.Width; 
//         set => base.Width = base.Height = value; 
//     }

//     public override double Height { 
//         get => base.Height; 
//         set => base.Height = base.Width = value; 
//     }

// }
