using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Circle
    {
        public double radiusR;
        public double areaCircle;
        public double perimeterCircle;
        public void AreaC(double radiusR)
        {
            areaCircle = 3.14 * radiusR;
            Console.WriteLine(areaCircle);
            
        }
        public void PerimeterC(double radiusR)
        {
            perimeterCircle = 2 * 3.14 * radiusR;
            Console.WriteLine(perimeterCircle);
         
        }
    }
    public class Rectangle
    {
        public double heightH;
        public double widthW;
        public double areaR;
        public double perimeterR;
        public void AreaR(double heightH, double widthW)
        {
            areaR = heightH * widthW;
            Console.WriteLine(areaR);
            
        }
        public void PerimeterR(double heightH, double widthW)
        {
            perimeterR = (heightH + widthW) * 2;
            Console.WriteLine(perimeterR);
        }
    }
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double areaT;
        public double perimeterT;
        public void AreaT(double a, double b, double c)
        {
            areaT = (a * c) / 2;
            Console.WriteLine(areaT);
           
        }
        public void PerimeterT(double a, double b, double c)
        {
            perimeterT = a + b + c;
            Console.WriteLine(perimeterT);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  public AreaC();
            Circle circle = new Circle();
            Circle circle1 = new Circle();
           
            circle.AreaC(4.0);
            circle1.PerimeterC(4.0);
            Triangle triangle = new Triangle();
            Triangle triangle1 = new Triangle();

            triangle.AreaT(1.0,2.0,3.0);
            triangle1.PerimeterT(1.0,2.0,3.0);
            Rectangle rectangle = new Rectangle();
            Rectangle rectangle1 = new Rectangle();

            rectangle.AreaR(2.0,3.0);
            rectangle1.PerimeterR(2.0,3.0);
            Console.ReadLine();
        }
    }
}
