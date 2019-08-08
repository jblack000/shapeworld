namespace ShapeWorld.Domain.Models
{
    public class Square : Rectangle // : is like extends
    {
      private double _edgeLength;
      public override double Length // why not virtual?
      { 
        get
        {
          return _edgeLength;
        }
      
        set
        {
          _edgeLength = value;
        }

      }

      public override double Width 
      { 
        get
        {
          return _edgeLength;
        }
      
        set
        {
          _edgeLength = value;
        }

      }
      
      
    }
}