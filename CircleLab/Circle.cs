using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    internal class Circle
    {

        private double radius; // variable to store the radius of the circle. 

        // Properties: These allow us to get or set the radius of the circle
        public double Radius
        {
            get { return radius; } // gets radius and sets radius
            set 
            {
                // We check if the new radius is valid (greater than zero)
                if (value <= 0)
                {
                    // If not valid, we throw an error message
                    throw new ArgumentException("Radius must be greater than zero.");
                }
                // If the new radius is valid, we set it to our private variable
                radius = value;
            }
        }

        // Constructor: This method is called when we create a new Circle object
        public Circle(double radius)
        {
            // We check if the radius is valid (greater than zero)
            if (radius <= 0)
            {
                // If not valid, we throw an error message
                throw new ArgumentException("Radius must be greater than zero.");
            }

            // If the radius is valid, we store it in our private variable
            this.radius = radius;
        }



        // Methods: These are functions that perform calculations related to the circle
        public double CalculateDiameter() // Method to calculate the diameter of the circle
        {
            return 2 * radius;
        }

        public double CalculateCircumference() // Method to calculate the circumference of the circle
        {
            return 2 * Math.PI * radius; // We use the PI constant from the Math class
        }

        public double CalculateArea() // Method to calculate the area of the circle
        {
            return Math.PI * radius * radius; // We use the PI constant from the Math class
        }

        public void Grow() // Method to increase the radius of the circle
        {
            radius *= 2; // We double the radius
        }

        public double GetRadius() // Method to get the current radius of the circle
        {
            return radius;
        }
    }
}