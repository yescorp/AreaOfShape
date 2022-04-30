﻿using System;
 using ConsoleApp1.Exceptions;

 namespace ConsoleApp1
{
    public class Triangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle()
        {
            A = 1;
            B = 1;
            C = 1;
        }

        public Triangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a && a - b < c && a - c < b && b - c < a)
            {
                A = a;
                B = b;
                C = c;    
            }
            else
            {
                throw new TriangleDoesntExistException("The sides of the triangle are incorrect");
            }
            
        }
        
        public double CalculateShapeArea()
        {
            double s = SemiPerimeter();
            
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public double SemiPerimeter()
        {
            return (A + B + C) / 2;
        }

        public bool IsRectangular()
        {
            double tolerance = (A + B + C) / 200;
            return (Math.Abs(Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) < tolerance
                    || Math.Abs(Math.Pow(C, 2) + Math.Pow(B, 2) - Math.Pow(A, 2)) < tolerance
                    || Math.Abs(Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) < tolerance
                );
        }

        public override string ToString()
        {
            return "Triangle: with sides " + A + " " + B + " " + C;
        }
    }
}