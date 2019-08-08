using System;
using ShapeWorld.Domain.Collections;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
      // access regualr retrun name parameters
        private static void Main(string[] args)
        {
            PlayWithShape();
            PlayWithCollection();
        }

        private static void PlayWithShape()
        {
          Shape someShape = new Rectangle();
          Square someSquare = new Square();
          Rectangle someRectangle = new Rectangle() as Square; // casting
          // Rectangle subRectangle2 = (Square) new Rectangle();
          Shape someCube = new Cube();

          Console.WriteLine(someShape.Volume());
          Console.WriteLine(someSquare.Length);
        }

        private static void PlayWithCollection()
      {
        ShapeArray sa = new ShapeArray();
        sa.DimensionalArray();
        sa.MyList();
        sa.MyDictionary();
      }

    }
}
