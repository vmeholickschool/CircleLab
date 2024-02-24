using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    internal class Circle
    {

        private double radius;


        public double Radius
        {
            get { return radius; }
            set
            {

                if (value <= 0)
                {

                    throw new ArgumentException("Radius must be greater than zero.");
                }

                radius = value;
            }
        }


        public Circle(double radius)
        {

            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero.");
            }

            this.radius = radius;
        }




        public double CalculateDiameter()
        {
            return radius * 2;
        }

        public double CalculateCircumference()
        {
            return Math.PI * radius * 2;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public void Grow()
        {
            radius *= 2;
        }

        public double GetRadius()
        {
            return radius;
        }
    }
}