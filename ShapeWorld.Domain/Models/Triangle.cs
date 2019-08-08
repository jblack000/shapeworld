namespace ShapeWorld.Domain.Models
{
  public class Triangle : Shape
  {
    public override double Surface()
    {
      return 0;
    }
    // height = 
    public Triangle() : base(3) {}
  }
}