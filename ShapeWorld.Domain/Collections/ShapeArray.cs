using System.Collections.Generic;
using ShapeWorld.Domain.Models;
using System.Linq;
using System;

namespace ShapeWorld.Domain.Collections
{
    public class ShapeArray
    {
      public void DimensionalArray()
      {
        // 1D Array
        Shape[] shaped = new Shape[10];
        Shape[] shaped2 = new Shape[]{new Square()};

        // 2D Array
        Shape[,] shaped3 = new Shape[2,2];
        Shape[,] shaped4 = new Shape[,] 
        {
          {new Square(), new Square()}, 
          {new Cube(), new Triangle()}
        };

        // 3D Array
        Shape[,,] shaped5 = new Shape[3,3,3];
        Shape[,,] shaped56 = new Shape[,,]
        {
          {{new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}},
          {{new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}},
          {{new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}},
          
        };

        // Read
        System.Console.WriteLine(shaped2[0]);
        System.Console.WriteLine(shaped4[1,0]);

        // Write
        shaped2[0] = new Circle();
        shaped4[1,0] = new Cube();
        shaped56[1,0,2] = new Rectangle();

        // Jagged Array
        Shape[][] shaped7 = new Shape[10][];
        Shape[][] shapde8 = new Shape[][]
        {
          new Rectangle[10],
          new Circle[]{ new Circle(), new Circle()}
        };

        System.Console.WriteLine(shapde8[1][1]);

      }

      public void MyList()
      {
        // Lists are arrays that are linked together
        // Fancy arrays with better search
        List<Shape> shaped = new List<Shape>();
        List<Shape> shaped2 = new List<Shape> {new Cube(), new Cube()};

        List<Shape[][,,]> shaped3 = new List<Shape[][,,]>();
        List<Shape[][,,]> shaped4 = new List<Shape[][,,]>{ new Shape[5][,,] };
        

        // REad from List
        System.Console.WriteLine(shaped2[1]);
        System.Console.WriteLine(shaped2.Find(e => e.NumberOfEdges == 4)); // predicate function; we dont know where the array start or stops
        System.Console.WriteLine(shaped2.FirstOrDefault(e => e.NumberOfEdges == 4));

        // Write to List
        
        try
        {
            shaped2[100] = new Rectangle(); // List is dynamic, so space is allocated intead of an error (as seen in an array)
            
        }
        catch(NullReferenceException ex)
        {
            throw; // whoever calls this (Program.cs, specifically PlayWithCollections), it now has to deal with it
        }
        catch(OverflowException ex)
        {
          shaped2.Add(new Rectangle());
        }
        catch(Exception ex)
        {
            throw new Exception("message", ex); // says the error "happened" on line 88; use when you dont want people to know your logic
        }
        finally // used for object garbage collection
        {
          GC.Collect();
          System.Console.WriteLine("It is final");
        }
        
        shaped2.Add(new Triangle());
        shaped2.AddRange(shaped2);

        // Remove from List
        shaped2.Remove(new Cube());
      }

      public void MyDictionary()
      {
        Dictionary<string, Shape> shaped = new Dictionary<string, Shape>();
        Dictionary<string, List<Shape>> shaped2 = new Dictionary<string, List<Shape>>()
        {
          {"square", new List<Shape>()} // {Key, Value}
        };

        // Read a dictionary
        System.Console.WriteLine(shaped2["square"]);
        shaped2.Select(d => d.Key == "square");

        // Write to Dictionary
        shaped2["square"] = new List<Shape>(); // will add, or update if square exists 
        shaped2.Add("square", new List<Shape>()); // doesnt update; if it does find square, an error will occur; recommend this using method
        try
        {
          shaped2.Add("square", new List<Shape>());
        }
        catch(Exception)
        {
          shaped2["square"] = new List<Shape>();
        }

      }

      
      
    }
}