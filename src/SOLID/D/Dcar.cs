using System;

namespace DesingPatternOOP_.src.SOLID.D;

public class Dcar
{
   private IDengine dengine;

   public Dcar( IDengine dengine)
   {
       this.dengine = dengine;
   }

   public void StartCar()
   {
       dengine.Start();
       Console.WriteLine("Car started.");
   }
}
