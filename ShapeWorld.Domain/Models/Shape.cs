namespace ShapeWorld.Domain.Models
{
    public abstract class Shape 
    {
      // fields
      // private int numberOfEdges; // when you make a field private, it's called a [backing field]

      // properties
      public int NumberOfEdges { get; }

      // methods
      public virtual double Perimeter()
      {
          return 0;
      }

      public abstract double Surface();

      public double Volume()
      {
        return 0;
      }

      // controllers [contructors]
      public Shape(int edges)
      {
        NumberOfEdges = edges;
      }

      public override string ToString()
      {
          return $"{this.GetType().Name} {NumberOfEdges}"; // GetType() uses reflection
      }
    }
}