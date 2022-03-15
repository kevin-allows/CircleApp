using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    internal class Circle
    {
        private double circleRadius;

        public void setCircleRadius(double circleRadius)
        {
            this.circleRadius = circleRadius;
        }

        public double getCircleRadius()
        {
            return circleRadius;
        }

        public double getCirclePerimeter()
        {
            return 2.0 * Math.PI * circleRadius;
        }

        public double getCircleArea()
        {
            return Math.PI * Math.Pow(circleRadius, 2.0);
        }

        public override string ToString()
        {
            return string.Format("Radius = {0}\r\nPerimeter = {1}\r\nArea = {2}\n\r",
            getCircleRadius(), getCirclePerimeter(), getCircleArea());
        }

    }
}