using System;
using System.Transactions;
using ConsoleApp1;
using ConsoleApp1.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateCircleShape()
        {
            for (int i = 0; i < 50; i++)
            {
                Circle circle = new Circle(new Random().NextDouble());

                double tolerance = 0.001;
                
                Assert.IsTrue(Math.Abs(circle.CalculateShapeArea() - circle.Radius * circle.Radius * Math.PI) < tolerance);
            }
        }

        [TestMethod]
        public void CalculateTriangleSemiPerimeter()
        {
            for (int i = 0; i < 50; i++)
            {
                try
                {
                    Triangle triangle = new Triangle(new Random().NextDouble() * 50, new Random().NextDouble() * 50,
                        new Random().NextDouble() * 50);
                    double tolerance = (triangle.A + triangle.B + triangle.C) / 1000;
                    double s = (triangle.A + triangle.B + triangle.C) / 2;
                    Assert.IsTrue(Math.Abs(triangle.SemiPerimeter() - s) < tolerance);
                }
                catch (TriangleDoesntExistException ex)
                {
                    Console.WriteLine("wrong triangle generated randomly");
                }
                catch (Exception ex)
                {
                    throw new AssertFailedException(ex.Message);
                }
            }
        }

        [TestMethod]
        public void CalculateTriangleArea()
        {
            for (int i = 0; i < 50; i++)
            {
                try
                {
                    Triangle triangle = new Triangle(new Random().NextDouble() * 50, new Random().NextDouble() * 50,
                        new Random().NextDouble() * 50);
                    double tolerance = (triangle.A + triangle.B + triangle.C) / 1000;
                    double s = triangle.SemiPerimeter();
                    double area = Math.Sqrt(s * (s - triangle.A) * (s - triangle.B) * (s - triangle.C));
                    Console.WriteLine(triangle.ToString());
                    Console.WriteLine(triangle.CalculateShapeArea() + " = " + area);
                    Assert.IsTrue(Math.Abs(triangle.CalculateShapeArea() - area) < tolerance);
                }
                catch (TriangleDoesntExistException ex)
                {
                    Console.WriteLine("wrong triangle generated randomly");
                }
                catch (Exception ex)
                {
                    throw new AssertFailedException(ex.Message);
                }
            }
        }

        [TestMethod]
        public void CalculateCustomShapeArea()
        {
            for (int i = 0; i < 50; i++)
            {
                double a = new Random().NextDouble() * 50;
                double b = new Random().NextDouble() * 50;
                IShape rect = new Rectangle(a, b);
            
                Assert.IsTrue(Math.Abs(rect.CalculateShapeArea() - a * b) < 0.00001);   
            }
        }
    }
}