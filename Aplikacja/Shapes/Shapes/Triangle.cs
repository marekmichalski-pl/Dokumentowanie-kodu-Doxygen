using System;

namespace Shapes
{
    /// <summary>
    /// Description of triangle object.
    /// </summary>
    class Triangle : IShape
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        /// <summary>
        /// Define rectangle (constructor).
        /// </summary>
        /// <param name="a">side a</param>
        /// <param name="b">side b</param>
        /// <param name="c">side c</param>
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Calculation S value (Heron formula).
        /// </summary>
        /// <returns>p (Heron formula)</returns>
        private double CalculateS()
        {
            return (0.5 * (a + b + c));
        }

        /// <summary>
        /// Calculation of triangle area.
        /// \image html Herons-Formula.png
        /// \image latex Herons-Formula.png
        /// </summary>
        /// <returns>Triangle area.</returns>
        /// <exception cref="ArgumentException">Creating a triangle is not possible with defined a, b, c.</exception>
        public double GetArea()
        {
            double d;
            double s;

            s = CalculateS();

            d = s * (s - a) * (s - b) * (s - c);

            if (d < 0)
                throw new System.ArgumentException("It is not triangle.");

            return Math.Sqrt(d);
        }

        /// <summary>
        /// Calculation of triangle perimeter.
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            /// \todo Add to function body (perimeter for triangle).
            //TODO Add to function body (perimeter for triangle).
            return 0;
        }

        /// <summary>
        /// Info about triangle.
        /// </summary>
        /// <returns>Info about triangle.</returns>
        public string Info()
        {
            return string.Format("Triangle. Area: {0:0.##}, perimeter: {1:0.##}", GetArea(), GetPerimeter());
        }
    }
}
