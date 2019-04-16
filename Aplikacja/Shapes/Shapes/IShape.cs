namespace Shapes
{ 
    /// <summary>
    /// Interface for shapes classes. 
    /// </summary>
    interface IShape
    { 
        double GetArea();
        double GetPerimeter();
        string Info();
    }
}
