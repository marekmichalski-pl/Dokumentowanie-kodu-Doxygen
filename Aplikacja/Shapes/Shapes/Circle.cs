using System;

namespace Shapes
{
    /// <summary>
    /// Description of circle object.
    /// </summary>
    class Circle :IShape
    {
        private readonly double r;

        /// <summary>
        /// Define circle (constructor).
        /// </summary>
        /// <param name="r">radius</param>
        public Circle(double r)
        {
            this.r = r;
        }

        /// <summary>
        /// Calculation of circle area.
        /// </summary>
        /// <returns>Circle area.</returns>
        public double GetArea()
        {
            return Math.PI * r * r;
        }

        /// <summary>
        /// Calculation of circle perimeter.
        /// </summary>
        /// <returns>Circle perimeter.</returns>
        public double GetPerimeter()
        {
            return 2 * Math.PI * r;
        }

        /// <summary>
        /// Info about cirlce.
        /// </summary>
        /// <returns>Info about circle.</returns>
        public string Info()
        {
            return string.Format("Circle. Area: {0:0.##}, perimeter: {1:0.##}", GetArea(), GetPerimeter());
        }
    }
}
