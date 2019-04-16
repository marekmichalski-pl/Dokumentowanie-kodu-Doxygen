namespace Shapes
{
    /// <summary>
    /// Description of rectangle objects.
    /// </summary>
    class Rectangle : IShape
    {
        private readonly double a;
        private readonly double b;

        /// <summary>
        /// Define rectangle (constructor).
        /// </summary>
        /// <param name="a">side a</param>
        /// <param name="b">side b</param>
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b; 
        }

        /// <summary>
        /// Calculation of rectangle area.
        /// </summary>
        /// <returns>Rectangle area</returns>
        public double GetArea()
        {
            return a*b;
        }

        /// <summary>
        /// Calculation of rectangle perimeter.
        /// </summary>
        /// <returns>Rectangle perimeter.</returns>
        public double GetPerimeter()
        {
            return 2*b + 2*b;
        }

        /// <summary>
        /// Info about rectangle.
        /// </summary>
        /// <returns>Info about rectangle.</returns>
        public string Info()
        {
            return string.Format("Rectangle. Area: {0:0.##}, perimeter: {1:0.##}", GetArea(), GetPerimeter());
        }
    }
}

