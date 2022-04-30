﻿using System;

namespace ConsoleApp1
{
    public class Circle : IShape
    {
        public Circle()
        {
            Radius = 1;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
        
        public double Radius { get; set; }
        
        public double CalculateShapeArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}