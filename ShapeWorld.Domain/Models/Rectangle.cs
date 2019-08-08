namespace ShapeWorld.Domain.Models
{
  public class Rectangle : Shape 
  {
    public virtual double Length {get; set;}
    public virtual double Width {get; set;}
    
    public override double Surface()
    {
      return Length * Width;
    }

    public new double Volume() // why new?
    {
      return 1234;
    }

    public override double Perimeter()
    {
      return 2 * (Length + Width);
    }
    public Rectangle() : base(4) {}
  }
}