namespace ShapeWorld.Domain.Models
{
  public class Circle : Shape
  {
    public override double Surface()
    {
      return 0;
    }
    // height = 
    public Circle() : base(int.MaxValue) {}
  }
}